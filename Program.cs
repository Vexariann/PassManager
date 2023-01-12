using Microsoft.Extensions.DependencyInjection;
using PassManager.Winforms;

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

            Services.ServiceProvider = services.BuildServiceProvider();
            var pMHome = Services.ServiceProvider.GetRequiredService<PMHome>();

            Application.Run(pMHome);
        }
    }
}