using System;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp.DataService;
using WindowsFormsApp.Models;
namespace WindowsFormsApp.View
{
    public partial class formAuthors : Form
    {
        public formAuthors()
        {
            InitializeComponent();
        }
        #region Method
        void Retrieve()
        {
            using (var context = new MyDbContext())
            {
                var result = from c in context.myAuthors
                             select new { c.Id, c.NameAuthors };
                dataGridViewAuthors.DataSource = result.ToList();
            }
        }
        private void permision(string permision)
        {
            switch (permision)
            {
                case "quản lý":
                    btnDelete.Enabled = true;
                    btnUpdate.Enabled = true;
                    btnAdd.Enabled = true;
                    btnReload.Enabled = true;
                    break;
                case "nhân viên":
                    btnDelete.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnAdd.Enabled = false;
                    btnReload.Enabled = true;
                    break;
            }
        }
        int Insert()
        {
            using (var context = new MyDbContext())
            {
                var c = new Authors()
                {
                    NameAuthors = txbNameAuthors.Text
                };
                context.myAuthors.Add(c);
                return context.SaveChanges();
            }
        }
        int Update()
        {
            using (var context = new MyDbContext())
            {
                try
                {
                    int IDC = int.Parse(txbIdAuthors.Text);
                    var rowToUpdate = context.myAuthors.SingleOrDefault(r => r.Id == IDC);
                    if (rowToUpdate != null)
                    {
                        rowToUpdate.NameAuthors = txbNameAuthors.Text;
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
                    int IDC = int.Parse(txbIdAuthors.Text);
                    var rowToDelete = context.myAuthors.SingleOrDefault(r => r.Id == IDC);
                    if (rowToDelete != null) context.myAuthors.Remove(rowToDelete);
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
                var result = from c in context.myAuthors
                                 //where key.Contains(c.NameAuthors)
                             where c.NameAuthors.Contains(key)
                             select new { c.Id, c.NameAuthors };
                dataGridViewAuthors.DataSource = result.ToList();
            }
        }
        #endregion
        #region events
        private void formAuthors_Load(object sender, EventArgs e)
        {
            Retrieve();
            permision(formMain.__Permision);

            dataGridViewAuthors.Columns["Id"].HeaderText = "Mã tác giả";
            dataGridViewAuthors.Columns["NameAuthors"].HeaderText = "Tên tác giả";
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
            formAuthors_Load(sender, e);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search(txbSearch.Text);
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
            formAuthors_Load(sender, e);
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            formAuthors_Load(sender, e);
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
            formAuthors_Load(sender, e);
        }
        private void dataGridViewAuthors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                using (var context = new MyDbContext())
                {
                    int IDC = int.Parse(dataGridViewAuthors.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                    var rowToSelect = context.myAuthors.SingleOrDefault(r => r.Id == IDC);
                    if (rowToSelect != null)
                    {
                        txbIdAuthors.Text = rowToSelect.Id.ToString();
                        txbNameAuthors.Text = rowToSelect.NameAuthors;
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
