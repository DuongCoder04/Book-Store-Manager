using WindowsFormsApp.View;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class formMain : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public static string __UserName;
        public static string __Password;
        public static string __Permision;
        public formMain()
        {
            InitializeComponent();
        }
        private void btnBook_Click(object sender, EventArgs e)
        {
            formBook f = new formBook();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            formCategory f = new formCategory();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnAuthors_Click(object sender, EventArgs e)
        {
            formAuthors f = new formAuthors();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            formStaff f = new formStaff();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnPublisher_Click(object sender, EventArgs e)
        {
            formPublisher f = new formPublisher();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            ShowLoginForm();
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            if (ShowLoginForm() > 0)
            {
                this.Show();
            }
        }
        private void permision(string permision)
        {
            switch (permision)
            {
                case "quản lý":
                    rbUser.Enabled = true;
                    break;
                case "nhân viên":
                    rbUser.Enabled = false;
                    break;
            }
        }
        public int ShowLoginForm()
        {
            using (var loginForm = new formLogin())
            {
                DialogResult result = loginForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    __UserName = loginForm._username;
                    __Password = loginForm._password;
                    __Permision = loginForm._permision;
                    permision(loginForm._permision);
                    return 1;
                }
                return 0;
            }
        }
        private void btnUser_Click(object sender, EventArgs e)
        {
            using (var formlogin = new formLogin())
            {
                 formUser f = new formUser();
                 this.Hide();
                 f.ShowDialog();
                 this.Show();
            }
        }

        private void btnChangePW_Click(object sender, EventArgs e)
        {
            formChangePassword f = new formChangePassword();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            formBill f = new formBill();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
