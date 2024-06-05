using System;
using System.Windows.Forms;
using WindowsFormsApp.DataService;

namespace WindowsFormsApp.View
{
    public partial class formChangePassword : Form
    {
        public formChangePassword()
        {
            InitializeComponent();
        }

        private void formChangePassword_Load(object sender, EventArgs e)
        {
            txbUserName.Text = formMain.__UserName;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (CryptoLib.Encryptor.MD5Hash(txbCurrentPw.Text) == formMain.__Password)
            {
                if (txbNewPw.Text != string.Empty)
                {
                    if (txbRenew.Text == txbNewPw.Text)
                    {
                        if (formUser.ChangePass(txbUserName.Text, txbNewPw.Text) > 0)
                        {
                            MessageBox.Show("Đổi mật khẩu thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            this.Close();
                        }
                        
                    }
                    else if(txbRenew.Text != txbNewPw.Text)
                    {
                        MessageBox.Show("Nhập lại mật khẩu mới không trùng khớp !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu mới !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu hiện tại không chính xác !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
