using System;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp.DataService;
using WindowsFormsApp.Models;

namespace WindowsFormsApp.View
{
    public partial class formLogin : Form
    {
        public string _permision;
        public string _username;
        public string _password;

        public formLogin()
        {
            InitializeComponent();
        }

        private void formLogin_Load(object sender, EventArgs e)
        {
            CheckDefaultUser();
            LoadSavedCredentials();
        }
        private void CheckDefaultUser()
        {
            using (var context = new MyDbContext())
            {
                if (!context.myUser.Any())
                {
                    var defaultUser = new User
                    {
                        UserName = "admin",
                        Password = CryptoLib.Encryptor.MD5Hash("admin"),
                        Permision = "quản lý"
                    };
                    context.myUser.Add(defaultUser);
                    context.SaveChanges();
                }
            }
        }
        private bool AuthenticateUser(string username, string password)
        {
            using (var context = new MyDbContext())
            {
                var UserToLogin = context.myUser.SingleOrDefault(r => r.UserName == username && r.Password == password);
                if (UserToLogin != null)
                {
                    _permision = UserToLogin.Permision.ToLower();
                    return true;
                }
                return false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txbUserName.Text != string.Empty && txbPassword.Text != string.Empty)
            {
                _username = txbUserName.Text;
                _password = CryptoLib.Encryptor.MD5Hash(txbPassword.Text);

                if (AuthenticateUser(_username, _password))
                {
                    this.DialogResult = DialogResult.OK;
                    SaveCredentials();
                }
                else
                {
                    ShowLoginError();
                }
            }
            else
            {
                ShowLoginError();
            }
        }

        private void SaveCredentials()
        {
            if (ckbReAcc.Checked)
            {
                Properties.Settings.Default.UserName = txbUserName.Text;
                Properties.Settings.Default.Password = txbPassword.Text; 
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.UserName = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Save();
            }
        }

        private void LoadSavedCredentials()
        {
            if (!string.IsNullOrEmpty(Properties.Settings.Default.UserName))
            {
                txbUserName.Text = Properties.Settings.Default.UserName;
                txbPassword.Text = Properties.Settings.Default.Password;
            }
        }

        private void ShowLoginError()
        {
            if (MessageBox.Show("Thông tin tài khoản và mật khẩu không chính xác vui lòng đăng nhập lại!", "Cảnh báo", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
            {
                Application.Exit();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
                Application.Exit();
        }
        private void btnShowp_Click(object sender, EventArgs e)
        {
            txbPassword.UseSystemPasswordChar = !txbPassword.UseSystemPasswordChar;
        }
    }
}

