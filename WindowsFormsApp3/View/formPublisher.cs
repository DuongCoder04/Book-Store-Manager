using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp.DataService;
using WindowsFormsApp.Models;

namespace WindowsFormsApp.View
{
    public partial class formPublisher : Form
    {
        public formPublisher()
        {
            InitializeComponent();
        }
        #region Method
        void Retrieve()
        {
            using (var context = new MyDbContext())
            {
                var result = from c in context.myPublisher
                             select new { c.Id, c.NamePublisher };
                dataGridViewPublisher.DataSource = result.ToList();
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
                var c = new Publisher()
                {
                    NamePublisher = txbNamePublisher.Text
                };
                context.myPublisher.Add(c);
                return context.SaveChanges();
            }
        }
        int Update()
        {
            using (var context = new MyDbContext())
            {
                try
                {
                    int IDP = int.Parse(txbIdPublisher.Text);
                    var rowToUpdate = context.myPublisher.SingleOrDefault(r => r.Id == IDP);
                    if (rowToUpdate != null)
                    {
                        rowToUpdate.NamePublisher = txbNamePublisher.Text;
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
                    int IDP = int.Parse(txbIdPublisher.Text);
                    var rowToDelete = context.myPublisher.SingleOrDefault(r => r.Id == IDP);
                    if (rowToDelete != null) context.myPublisher.Remove(rowToDelete);
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

                var result = from c in context.myPublisher
                             where c.NamePublisher.Contains(key)
                             select new { c.Id, c.NamePublisher };
                dataGridViewPublisher.DataSource = result.ToList();
            }
        }
        #endregion
        #region Event
        private void formPublisher_Load(object sender, EventArgs e)
        {
            Retrieve();
            permision(formMain.__Permision);
            dataGridViewPublisher.Columns["Id"].HeaderText = "Mã nhà xuất bản";
            dataGridViewPublisher.Columns["NamePublisher"].HeaderText = "Tên nhà xuất bản";
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
            formPublisher_Load(sender, e);
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
            formPublisher_Load(sender, e);
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            formPublisher_Load(sender, e);
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
            formPublisher_Load(sender, e);
        }
        private void dataGridViewPublisher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                using (var context = new MyDbContext())
                {
                    int IDP = int.Parse(dataGridViewPublisher.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                    var rowToSelect = context.myPublisher.SingleOrDefault(r => r.Id == IDP);
                    if (rowToSelect != null)
                    {
                        txbIdPublisher.Text = rowToSelect.Id.ToString();
                        txbNamePublisher.Text = rowToSelect.NamePublisher;
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
