using System;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp.DataService;
using WindowsFormsApp.Models;

namespace WindowsFormsApp.View
{
    public partial class formCategory : Form
    {
        public formCategory()
        {
            InitializeComponent();
        }
        #region Method
        void Retrieve()
        {
            using (var context = new MyDbContext())
            {
                var result = from c in context.myCategory
                             select new { c.Id, c.NameCategory };
                dataGridViewCategory.DataSource = result.ToList();
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
                var c = new Category()
                {
                    NameCategory = txbNameCategory.Text
                };
                context.myCategory.Add(c);
                return context.SaveChanges();
            }
        }
        int Update()
        {
            using (var context = new MyDbContext())
            {
                try
                {
                    int IDC = int.Parse(txbIdCategory.Text);
                    var rowToUpdate = context.myCategory.SingleOrDefault(r => r.Id == IDC);
                    if (rowToUpdate != null)
                    {
                        rowToUpdate.NameCategory = txbNameCategory.Text;
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
                    int IDC = int.Parse(txbIdCategory.Text);
                    var rowToDelete = context.myCategory.SingleOrDefault(r => r.Id == IDC);
                    if (rowToDelete != null) context.myCategory.Remove(rowToDelete);
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

                var result = from c in context.myCategory
                             where c.NameCategory.Contains(key)
                             select new { c.Id, c.NameCategory };
                dataGridViewCategory.DataSource = result.ToList();
            }
        }
        #endregion
        #region events
        private void formCategory_Load(object sender, EventArgs e)
        {
            Retrieve();
            permision(formMain.__Permision);
            dataGridViewCategory.Columns["Id"].HeaderText = "Mã loại sách";
            dataGridViewCategory.Columns["NameCategory"].HeaderText = "Tên loại sách";
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
            formCategory_Load(sender, e);
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
            formCategory_Load(sender, e);
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            formCategory_Load(sender, e);
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
            formCategory_Load(sender, e);
        }
        private void dataGridViewCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                using (var context = new MyDbContext())
                {
                    int IDC = int.Parse(dataGridViewCategory.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                    var rowToSelect = context.myCategory.SingleOrDefault(r => r.Id == IDC);
                    if (rowToSelect != null)
                    {
                        txbIdCategory.Text = rowToSelect.Id.ToString();
                        txbNameCategory.Text = rowToSelect.NameCategory;
                    }
                }
            }
        }
        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
            string[] arr = txbSearch.Text.Split();
            for (int i = 0; i < arr.Length; i++)
            {
                string digit = arr[i];
                Search(digit);
            }
        }
        #endregion
    }
}
