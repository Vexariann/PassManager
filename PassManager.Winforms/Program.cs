using Microsoft.Extensions.DependencyInjection;
using PassManager.Winforms;
using System.Text.Json;

namespace PassManager
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var services = new ServiceCollection();
            services.AddScoped<PMHome>();
            services.AddScoped<LoginWindow>();
            services.AddScoped<PMDashboard>();
            services.AddScoped<DebugForm>();
            services.AddScoped<Rootobject>();

            Services.ServiceProvider = services.BuildServiceProvider();
            var pMHome = Services.ServiceProvider.GetRequiredService<PMHome>();

            Application.Run(pMHome);
        }
        public static Rootobject GetAppInfo()
        {
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
            string path = Path.Combine(projectDirectory, @"AppInfo.json");
            string jsonData = File.ReadAllText(path);
            Rootobject appInfo = JsonSerializer.Deserialize<Rootobject>(jsonData);
            return appInfo;
        }
    }
}