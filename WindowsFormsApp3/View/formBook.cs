using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp.DataService;
using WindowsFormsApp.Models;

namespace WindowsFormsApp.View
{
    public partial class formBook : Form
    {
        public formBook()
        {
            InitializeComponent();
        }
        #region Method
        void Retrieve()
        {
            using (var context = new MyDbContext())
            {
                cbAuthors.DataSource = context.myAuthors.ToList();
                cbAuthors.DisplayMember = "NameAuthors";
                cbAuthors.ValueMember = "ID";
                cbCategory.DataSource = context.myCategory.ToList();
                cbCategory.DisplayMember = "NameCategory";
                cbCategory.ValueMember = "ID";
                cbPublisher.DataSource = context.myPublisher.ToList();
                cbPublisher.DisplayMember = "NamePublisher";
                cbPublisher.ValueMember = "ID";
                var result = from c in context.myBooks
                             select new { c.Id, c.Title,c.IdAuthors,c.IdPublisher, c.Year, c.Edition,c.IdCategory, c.Tags, c.Reading, c.Rating, c.Description, c.FileDirection, c.FileName , c.Price};
                dataGridViewBook.DataSource = result.ToList();
            }
        }
        void permision(string permision)
        {
            switch (permision)
            {
                case "quản lý":
                    btnInsert.Enabled = true;
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                    btnReLoad.Enabled = true;
                    break;
                case "nhân viên":
                    btnDelete.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnInsert.Enabled = false;
                    btnReLoad.Enabled = true;
                    break;
            }
        }
        int Insert()
        {
            using (var context = new MyDbContext())
            {
                int year, edition, rate; bool r;
                var b = new Book()
                {
                    Title = txbTitle.Text,
                    IdAuthors = int.Parse(cbAuthors.SelectedValue.ToString()),
                    IdPublisher = int.Parse(cbPublisher.SelectedValue.ToString()),
                    IdCategory = int.Parse(cbCategory.SelectedValue.ToString()),
                    Rating = int.TryParse(txbRating.Text, out rate) ? rate : 0,
                    Description = txbDescription.Text,
                    Year = (int.TryParse(txbYear.Text, out year) ? year : 0),
                    Edition = (int.TryParse(txbEdition.Text, out edition) ? edition : 0),
                    Tags = txbTags.Text,
                    FileDirection = txbFileDirection.Text,
                    Reading = (bool.TryParse(ckbReading.Checked.ToString(), out r) ? r : false),
                    FileName = txbFileName.Text,
                    Price = int.Parse(txbPrice.Text),
                };
                context.myBooks.Add(b);
                return context.SaveChanges();
            }
        }
        int Update()
        {
            using (var context = new MyDbContext())
            {
                try
                {
                    int IDB = int.Parse(txbIdBook.Text);
                    var rowToUpdate = context.myBooks.SingleOrDefault(r => r.Id == IDB);
                    int year, edition, rate; bool rd;
                    if (rowToUpdate != null)
                    {
                        rowToUpdate.Title = txbTitle.Text;
                        rowToUpdate.IdAuthors = int.Parse(cbAuthors.SelectedValue.ToString());
                        rowToUpdate.IdCategory = int.Parse(cbCategory.SelectedValue.ToString());
                        rowToUpdate.IdPublisher = int.Parse(cbPublisher.SelectedValue.ToString());
                        rowToUpdate.Rating = int.TryParse(txbRating.Text, out rate) ? rate : 0;
                        rowToUpdate.Description = txbDescription.Text;
                        rowToUpdate.Year = (int.TryParse(txbYear.Text, out year) ? year : 0);
                        rowToUpdate.Edition = (int.TryParse(txbEdition.Text, out edition) ? edition : 0);
                        rowToUpdate.Tags = txbTags.Text;
                        rowToUpdate.FileDirection = txbFileDirection.Text;
                        rowToUpdate.Reading = (bool.TryParse(ckbReading.Checked.ToString(), out rd) ? rd : false);
                        rowToUpdate.FileName = txbFileName.Text;
                        rowToUpdate.Price = int.Parse(txbPrice.Text);
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
                    int IDB = int.Parse(txbIdBook.Text);
                    var rowToDelete = context.myBooks.SingleOrDefault(r => r.Id == IDB);
                    if (rowToDelete != null) context.myBooks.Remove(rowToDelete);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message,"Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return context.SaveChanges();
            }
        }
        void Search(string key)
        {
            using (var context = new MyDbContext())
            {
                var result = from c in context.myBooks
                             where c.Title.Contains(key) || c.Tags.Contains(key) || c.Description.Contains(key) || c.Authors.NameAuthors.Contains(key) || c.Publisher.NamePublisher.Contains(key) || c.Category.NameCategory.Contains(key) || c.Year.ToString().Contains(key) || c.Price.ToString().Contains(key)
                             select new { c.Id, c.Title, c.IdAuthors, c.IdPublisher, c.Year, c.Edition, c.IdCategory, c.Tags, c.Reading, c.Rating, c.Description, c.FileDirection, c.FileName, c.Price };
                dataGridViewBook.DataSource = result.ToList();
            }
        }
        #endregion
        #region Events
        private void formBook_Load(object sender, EventArgs e)
        {
            Retrieve();
            permision(formMain.__Permision);

            dataGridViewBook.Columns["Id"].HeaderText = "Mã sách";
            dataGridViewBook.Columns["Title"].HeaderText = "Tên sách";
            dataGridViewBook.Columns["IdAuthors"].HeaderText = "Mã tác giả";
            dataGridViewBook.Columns["IdPublisher"].HeaderText = "Mã nhà xuất bản";
            dataGridViewBook.Columns["Year"].HeaderText = "Năm xuất bản";
            dataGridViewBook.Columns["Edition"].HeaderText = "Lần tái bản";
            dataGridViewBook.Columns["IdCategory"].HeaderText = "Mã loại sách";
            dataGridViewBook.Columns["Tags"].HeaderText = "Từ khóa";
            dataGridViewBook.Columns["Reading"].HeaderText = "Đã đọc";
            dataGridViewBook.Columns["Rating"].HeaderText = "Đánh giá";
            dataGridViewBook.Columns["Description"].HeaderText = "Mô tả";
            dataGridViewBook.Columns["FileDirection"].HeaderText = "Địa chỉ lưu trữ";
            dataGridViewBook.Columns["FileName"].HeaderText = "Tên file";
            dataGridViewBook.Columns["Price"].HeaderText = "Giá thành";
            dataGridViewBook.Columns["Price"].DefaultCellStyle.Format = "C0";
            dataGridViewBook.Columns["Price"].DefaultCellStyle.FormatProvider = new System.Globalization.CultureInfo("vi-VN");
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (Insert() > 0)
            {
                MessageBox.Show("Thêm dữ liệu thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Thêm dữ liệu không thành công", "Thông báo");
            }
            formBook_Load(sender, e);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "Chọn file (*.pdf)|*.pdf|All files (*.*)|*.*";

                DialogResult dlgRes = dlg.ShowDialog();
                if (dlgRes != DialogResult.Cancel)
                {
                    txbFileDirection.Text = dlg.FileName;
                    txbFileName.Text = dlg.SafeFileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridViewBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                using (var context = new MyDbContext())
                {
                    int IDB = int.Parse(dataGridViewBook.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                    var rowToSelect = context.myBooks.SingleOrDefault(r => r.Id == IDB);
                    if (rowToSelect != null)
                    {
                        txbIdBook.Text = rowToSelect.Id.ToString();
                        txbTitle.Text = rowToSelect.Title;
                        cbAuthors.SelectedValue = rowToSelect.IdAuthors;
                        cbPublisher.SelectedValue = rowToSelect.IdPublisher;
                        cbCategory.SelectedValue = rowToSelect.IdCategory;
                        txbRating.Text = rowToSelect.Rating.ToString();
                        txbDescription.Text = rowToSelect.Description;
                        txbYear.Text = rowToSelect.Year.ToString();
                        txbEdition.Text = rowToSelect.Edition.ToString();
                        txbTags.Text = rowToSelect.Tags;
                        txbFileDirection.Text = rowToSelect.FileDirection;
                        ckbReading.Checked = rowToSelect.Reading;
                        txbFileName.Text = rowToSelect.FileName;
                        txbPrice.Text = rowToSelect.Price.ToString();
                    }
                }
            }
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
            formBook_Load(sender, e);
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
            formBook_Load(sender, e);
        }
        private void btnReLoad_Click(object sender, EventArgs e)
        {
            formBook_Load(sender, e);
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
