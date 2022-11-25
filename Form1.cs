using Microsoft.Extensions.DependencyInjection;
using PassManager.Winforms;

namespace PassManager
{
    public partial class PMHome : Form
    {
        public PMHome()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            LoginWindow loginWindow = Services.ServiceProvider.GetService<LoginWindow>();
            if (loginWindow.ShowDialog() == DialogResult.OK)
            {
                throw new NotImplementedException();
            }
        }
    }
}