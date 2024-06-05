using System;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp.DataService;

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
        #region method
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
        #endregion
        private void btnLogin_Click(object sender, EventArgs e)
        {
            _username = txbUserName.Text;
            _password = CryptoLib.Encryptor.MD5Hash(txbPassword.Text);
            if (AuthenticateUser(_username, _password))
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                if(MessageBox.Show("Thông tin tài khoản và mật khẩu không chính xác vui lòng đăng nhập lại!","Cảnh báo",MessageBoxButtons.RetryCancel,MessageBoxIcon.Warning) == DialogResult.Cancel)
                {
                    Application.Exit();
                }
            }
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
        private void formLogin_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.UserName != string.Empty)
            {
                txbUserName.Text = Properties.Settings.Default.UserName;
                txbPassword.Text = Properties.Settings.Default.Password;
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn đóng chương trình không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnShowp_Click(object sender, EventArgs e)
        {
            if (txbPassword.UseSystemPasswordChar)
                txbPassword.UseSystemPasswordChar = false;
            else txbPassword.UseSystemPasswordChar = true;
        }
    }
}
