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
            LoginWindow addPhone = Services.ServiceProvider.GetService<LoginWindow>();
            if (addPhone.ShowDialog() == DialogResult.OK)
            {
                throw new NotImplementedException();
            }
        }
    }
}