using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp.DataService;
using WindowsFormsApp.Models;

namespace WindowsFormsApp.View
{
    public partial class formUser : Form
    {
        public formUser()
        {
            InitializeComponent();
        }
        #region Method
        void Retrieve()
        {
            using (var context = new MyDbContext())
            {
                var result = context.myUser;
                dataGridViewUser.DataSource = result.ToList();
            }
        }
        int Insert()
        {
            using (var context = new MyDbContext())
            {
                var c = new User()
                {
                    UserName = txbNameUser.Text,
                    Password = CryptoLib.Encryptor.MD5Hash(txbPassword.Text),
                    Permision = txbPermision.Text
                };
                context.myUser.Add(c);
                return context.SaveChanges();
            }
        }
        public static int ChangePass(string username, string password)
        {
            using (var context = new MyDbContext())
            {
                try
                {
                    var accToUpdate = context.myUser.SingleOrDefault(r => r.UserName == username);
                    if (accToUpdate != null)
                    {
                        accToUpdate.Password = CryptoLib.Encryptor.MD5Hash(password);
                    }
                    else return 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return context.SaveChanges();
            }
        }
        int Update()
        {
            using (var context = new MyDbContext())
            {
                try
                {
                    int IDU = int.Parse(txbIdUser.Text);
                    var rowToUpdate = context.myUser.SingleOrDefault(r => r.ID == IDU);
                    if (rowToUpdate != null)
                    {
                        rowToUpdate.UserName = txbNameUser.Text;
                        rowToUpdate.Password = CryptoLib.Encryptor.MD5Hash(txbPassword.Text);
                        rowToUpdate.Permision = txbPermision.Text;
                    }
                    else return 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return context.SaveChanges();
            }
        }
        int Delete()
        {
            using (var context = new MyDbContext())
            {
                try
                {
                    int IDU = int.Parse(txbIdUser.Text);
                    var rowToDelete = context.myUser.SingleOrDefault(r => r.ID == IDU);
                    if (rowToDelete != null) context.myUser.Remove(rowToDelete);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return context.SaveChanges();
            }
        }
        void Search(string key)
        {
            using (var context = new MyDbContext())
            {
                var result = from c in context.myUser
                             where c.UserName.Contains(key) || c.Permision.Contains(key)
                             select new { c.ID, c.UserName, c.Password, c.Permision };
                dataGridViewUser.DataSource = result.ToList();
            }
        }
        #endregion
        #region Event
        private void formUser_Load(object sender, EventArgs e)
        {
            Retrieve();
            dataGridViewUser.Columns["Id"].HeaderText = "Mã người dùng";
            dataGridViewUser.Columns["UserName"].HeaderText = "Tên người dùng";
            dataGridViewUser.Columns["Password"].HeaderText = "Mật khẩu";
            dataGridViewUser.Columns["Permision"].HeaderText = "Quyền truy cập";
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Insert() > 0)
            {
                MessageBox.Show("Thêm dữ liệu thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Thêm dữ liệu không thành công", "Thông báo");
            }
            formUser_Load(sender, e);
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Update() > 0)
            {
                MessageBox.Show("Sửa dữ liệu thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Sửa dữ liệu không thành công", "Thông báo");
            }
            formUser_Load(sender, e);
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            formUser_Load(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Delete() > 0)
            {
                MessageBox.Show("Xóa dữ liệu thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Xóa dữ liệu không thành công", "Thông báo");
            }
            formUser_Load(sender, e);
        }
        private void dataGridViewUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                using (var context = new MyDbContext())
                {
                    int IDU = int.Parse(dataGridViewUser.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                    var rowToSelect = context.myUser.SingleOrDefault(r => r.ID == IDU);
                    if (rowToSelect != null)
                    {
                        txbIdUser.Text = rowToSelect.ID.ToString();
                        txbNameUser.Text = rowToSelect.UserName;
                        txbPassword.Text = rowToSelect.Password;
                        txbPermision.Text = rowToSelect.Permision;
                    }
                }
            }
        }
        #endregion

        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
            string[] arr = txbSearch.Text.Split();
            for (int i = 0; i < arr.Length; i++)
            {
                string digit = arr[i];
                Search(digit);
            }
        }
    }
}
