using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp.DataService;
using WindowsFormsApp.Models;

namespace WindowsFormsApp.View
{
    public partial class formStaff : Form
    {
        public formStaff()
        {
            InitializeComponent();
        }
        #region Method
        void Retrieve()
        {
            using (var context = new MyDbContext())
            {
                var result = from c in context.myStaff
                             select new {c.Id, c.NameStaff, c.Address, c.Phone, c.Position };
                dataGridViewStaff.DataSource = result.ToList();
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
                var b = new Staff()
                {
                    NameStaff = txbNameStaff.Text,
                    Address = txbAddress.Text,
                    Phone = txbPhone.Text,
                    Position = txbPosition.Text
                };
                context.myStaff.Add(b);
                return context.SaveChanges();
            }
        }
        int Update()
        {
            using (var context = new MyDbContext())
            {
                try
                {
                    int IDS = int.Parse(txbIdStaff.Text);
                    var rowToUpdate = context.myStaff.SingleOrDefault(r => r.Id == IDS);
                    if (rowToUpdate != null)
                    {
                        rowToUpdate.NameStaff = txbNameStaff.Text;
                        rowToUpdate.Address = txbAddress.Text;
                        rowToUpdate.Phone = txbPhone.Text;
                        rowToUpdate.Position = txbPosition.Text;
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
                    int IDS = int.Parse(txbIdStaff.Text);
                    var rowToDelete = context.myStaff.SingleOrDefault(r => r.Id == IDS);
                    if (rowToDelete != null) context.myStaff.Remove(rowToDelete);
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
                var result = from c in context.myStaff
                             where c.NameStaff.Contains(key) || c.Address.Contains(key) || c.Phone.Contains(key) || c.Position.Contains(key)
                             select new { c.Id, c.NameStaff, c.Address, c.Phone, c.Position };
                dataGridViewStaff.DataSource = result.ToList();
            }
        }
        #endregion
        #region event
        private void formStaff_Load(object sender, EventArgs e)
        {
            Retrieve();
            permision(formMain.__Permision);

            dataGridViewStaff.Columns["Id"].HeaderText = "Mã nhân viên";
            dataGridViewStaff.Columns["NameStaff"].HeaderText = "Tên nhân viên";
            dataGridViewStaff.Columns["Address"].HeaderText = "Địa chỉ";
            dataGridViewStaff.Columns["Phone"].HeaderText = "Số điện thoại";
            dataGridViewStaff.Columns["Position"].HeaderText = "Chức vụ";

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
            formStaff_Load(sender, e);
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
            formStaff_Load(sender, e);
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
            formStaff_Load(sender, e);
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            formStaff_Load(sender, e);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dataGridViewStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                using (var context = new MyDbContext())
                {
                    int IDS = int.Parse(dataGridViewStaff.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                    var rowToSelect = context.myStaff.SingleOrDefault(r => r.Id == IDS);
                    if (rowToSelect != null)
                    {
                        txbIdStaff.Text = rowToSelect.Id.ToString();
                        txbNameStaff.Text = rowToSelect.NameStaff;
                        txbAddress.Text = rowToSelect.Address;
                        txbPhone.Text = rowToSelect.Phone;
                        txbPosition.Text = rowToSelect.Position;
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
