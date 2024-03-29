using System;
using System.Windows.Forms;

namespace Admin
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            if ("admin" == AdminPassword.Text)
            {
                Admin admin = new Admin();
                admin.Show();
            }
        }
    }
}
