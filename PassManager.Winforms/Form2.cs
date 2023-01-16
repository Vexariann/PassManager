namespace PassManager
{
    public partial class LoginWindow : Form
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void LoginCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
