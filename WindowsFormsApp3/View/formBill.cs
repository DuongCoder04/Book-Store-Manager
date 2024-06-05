using System;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp.DataService;
using WindowsFormsApp.Models;

namespace WindowsFormsApp.View
{
    public partial class formBill : Form
    {
        public formBill()
        {
            InitializeComponent();
        }

        #region Methods

        /// <summary>
        /// Lấy dữ liệu danh mục và hóa đơn từ cơ sở dữ liệu và đổ vào các điều khiển giao diện người dùng tương ứng.
        /// </summary>
        void Retrieve()
        {
            try
            {
                using (var context = new MyDbContext())
                {
                    // Lấy danh sách danh mục từ cơ sở dữ liệu
                    dtDate.Value =  DateTime.Now.Date;
                    var categories = context.myCategory
                                            .Select(c => new { c.Id, c.NameCategory })
                                            .ToList();
                    cbCategory.DataSource = categories;
                    cbCategory.DisplayMember = "NameCategory";
                    cbCategory.ValueMember = "Id";
                    cbCategory.SelectedIndex = -1;

                    // Lấy danh sách hóa đơn từ cơ sở dữ liệu
                    var bills = context.myBill
                                       .Select(c => new { c.Id, c.CheckOut, c.Status })
                                       .ToList();
                    dataGridViewBill.DataSource = bills;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateTotalLabel()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dataGridViewBillInfo.Rows)
            {
                if (row.Cells["Total"].Value != null)
                {
                    total += Convert.ToDecimal(row.Cells["Total"].Value);
                }
            }

            labelTotal.Text = total.ToString("C0", new System.Globalization.CultureInfo("vi-VN"));
        }

        /// <summary>
        /// Tải sách cho một danh mục nhất định và đổ vào combobox sách.
        /// </summary>
        /// <param name="categoryId">ID của danh mục.</param>
        void LoadBooksForCategory(int categoryId)
        {
            try
            {
                using (var context = new MyDbContext())
                {
                    var books = context.myBooks
                                       .Where(b => b.IdCategory == categoryId)
                                       .ToList();
                    cbBookName.DataSource = books;
                    cbBookName.DisplayMember = "Title";
                    cbBookName.ValueMember = "Id";
                    //cbBookName.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Thiết lập quyền dựa trên vai trò người dùng.
        /// </summary>
        /// <param name="permission">Vai trò quyền hạn.</param>
        void SetPermission(string permission)
        {
            switch (permission)
            {
                case "quản lý":
                    btnAddBill.Enabled = true;
                    btnAddBook.Enabled = true;
                    btnDelete.Enabled = true;
                    btnDeleteBook.Enabled = true;
                    btnUpdate.Enabled = true;
                    btnUpdateBI.Enabled = true;
                    break;
                case "nhân viên":
                    btnAddBill.Enabled = true;
                    btnAddBook.Enabled = true;
                    btnDelete.Enabled = false;
                    btnDeleteBook.Enabled = true;
                    btnUpdate.Enabled = true;
                    btnUpdateBI.Enabled = true;
                    break;
            }
        }

        /// <summary>
        /// Thêm hóa đơn mới vào cơ sở dữ liệu.
        /// </summary>
        /// <returns>Số lượng mục trạng thái được ghi vào cơ sở dữ liệu.</returns>
        int InsertBill()
        {
            try
            {
                using (var context = new MyDbContext())
                {
                    DateTime date = dtDate.Value;
                    bool status = ckbPay.Checked;
                    var bill = new Bill
                    {
                        CheckOut = date,
                        Status = status
                    };
                    context.myBill.Add(bill);
                    return context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        /// <summary>
        /// Thêm thông tin hóa đơn mới vào cơ sở dữ liệu.
        /// </summary>
        /// <returns>Số lượng mục trạng thái được ghi vào cơ sở dữ liệu.</returns>
        int InsertBillInfo()
        {
            try
            {
                using (var context = new MyDbContext())
                {
                    var billInfo = new BillInfo
                    {
                        IdBill = int.Parse(txbIdBill.Text),
                        IdBook = int.Parse(cbBookName.SelectedValue.ToString()),
                        Count = (int)nmCount.Value
                    };
                    context.myBillInfo.Add(billInfo);
                    return context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        /// <summary>
        /// Cập nhật hóa đơn hiện tại trong cơ sở dữ liệu.
        /// </summary>
        /// <returns>Số lượng mục trạng thái được ghi vào cơ sở dữ liệu.</returns>
        int UpdateBill()
        {
            try
            {
                using (var context = new MyDbContext())
                {
                    int billId = int.Parse(txbIdBill.Text);
                    var bill = context.myBill.SingleOrDefault(b => b.Id == billId);
                    if (bill != null)
                    {
                        bill.CheckOut = dtDate.Value;
                        bill.Status = ckbPay.Checked;
                        return context.SaveChanges();
                    }
                    return 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        /// <summary>
        /// Cập nhật thông tin hóa đơn hiện tại trong cơ sở dữ liệu.
        /// </summary>
        /// <returns>Số lượng mục trạng thái được ghi vào cơ sở dữ liệu.</returns>
        int UpdateBillInfo()
        {
            try
            {
                using (var context = new MyDbContext())
                {
                    int billId = int.Parse(txbIdBill.Text);
                    int billInfoId = int.Parse(txbIdBillInfo.Text);
                    var billInfo = context.myBillInfo.SingleOrDefault(bi => bi.Id == billInfoId && bi.IdBill == billId);
                    if (billInfo != null)
                    {
                        billInfo.IdBook = int.Parse(cbBookName.SelectedValue.ToString());
                        billInfo.Count = (int)nmCount.Value;
                        return context.SaveChanges();
                    }
                    return 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        /// <summary>
        /// Xóa hóa đơn hiện tại khỏi cơ sở dữ liệu.
        /// </summary>
        /// <returns>Số lượng mục trạng thái được ghi vào cơ sở dữ liệu.</returns>
        int DeleteBill()
        {
            try
            {
                using (var context = new MyDbContext())
                {
                    int billId = int.Parse(txbIdBill.Text);
                    var bill = context.myBill.SingleOrDefault(b => b.Id == billId);
                    if (bill != null)
                    {
                        context.myBill.Remove(bill);
                        return context.SaveChanges();
                    }
                    return 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        /// <summary>
        /// Xóa thông tin hóa đơn hiện tại khỏi cơ sở dữ liệu.
        /// </summary>
        /// <returns>Số lượng mục trạng thái được ghi vào cơ sở dữ liệu.</returns>
        int DeleteBillInfo()
        {
            try
            {
                using (var context = new MyDbContext())
                {
                    int billId = int.Parse(txbIdBill.Text);
                    int billInfoId = int.Parse(txbIdBillInfo.Text);
                    var billInfo = context.myBillInfo.SingleOrDefault(bi => bi.Id == billInfoId && bi.IdBill == billId);
                    if (billInfo != null)
                    {
                        context.myBillInfo.Remove(billInfo);
                        return context.SaveChanges();
                    }
                    return 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        /// <summary>
        /// Tìm kiếm hóa đơn dựa trên ngày được chọn.
        /// </summary>
        void Search()
        {
            try
            {
                using (var context = new MyDbContext())
                {
                    var results = context.myBill
                                         .Where(c => c.CheckOut <= dtDate.Value)
                                         .Select(c => new { c.Id, c.CheckOut, c.Status })
                                         .ToList();
                    dataGridViewBill.DataSource = results;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Events

        private void formBill_Load(object sender, EventArgs e)
        {
            Retrieve();
            SetPermission(formMain.__Permision);

            // Đổi tên các cột trong dataGridViewBill sang tiếng Việt
            dataGridViewBill.Columns["Id"].HeaderText = "Mã hóa đơn";
            dataGridViewBill.Columns["CheckOut"].HeaderText = "Ngày thanh toán";
            dataGridViewBill.Columns["Status"].HeaderText = "Trạng thái";

            cbCategory.SelectedIndex = -1;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (InsertBill() > 0)
            {
                MessageBox.Show("Thêm dữ liệu thành công.", "Thông báo");
            }
            else
            {
                MessageBox.Show("Thêm dữ liệu không thành công.", "Thông báo");
            }
            formBill_Load(sender, e);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    using (var context = new MyDbContext())
                    {
                        int billId = int.Parse(dataGridViewBill.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                        var bill = context.myBill.SingleOrDefault(b => b.Id == billId);
                        if (bill != null)
                        {
                            txbIdBill.Text = bill.Id.ToString();
                            dtDate.Value = bill.CheckOut;
                            ckbPay.Checked = bill.Status;

                            var billInfos = context.myBillInfo
                                                   .Where(bi => bi.IdBill == billId)
                                                   .Select(bi => new
                                                   {
                                                       bi.Id,
                                                       bi.Book.Title,
                                                       bi.Count,
                                                       Total = bi.Book != null ? bi.Book.Price * bi.Count : 0
                                                   })
                                                   .ToList();
                            dataGridViewBillInfo.DataSource = billInfos;

                            // Đổi tên các cột sang tiếng Việt
                            dataGridViewBillInfo.Columns["Id"].HeaderText = "STT";
                            dataGridViewBillInfo.Columns["Title"].HeaderText = "Tên sách";
                            dataGridViewBillInfo.Columns["Count"].HeaderText = "Số lượng";
                            dataGridViewBillInfo.Columns["Total"].HeaderText = "Tổng tiền (VND)";

                            // Định dạng cột Total thành tiền VND
                            dataGridViewBillInfo.Columns["Total"].DefaultCellStyle.Format = "C0";
                            dataGridViewBillInfo.Columns["Total"].DefaultCellStyle.FormatProvider = new System.Globalization.CultureInfo("vi-VN");

                            UpdateTotalLabel();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridViewBillInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    using (var context = new MyDbContext())
                    {
                        int billInfoId = int.Parse(dataGridViewBillInfo.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                        var billInfo = context.myBillInfo.SingleOrDefault(bi => bi.Id == billInfoId);
                        if (billInfo != null)
                        {
                            txbIdBillInfo.Text = billInfo.Id.ToString();
                            txbIdBill.Text = billInfo.IdBill.ToString();
                            cbBookName.SelectedValue = billInfo.IdBook;
                            cbCategory.SelectedValue = billInfo.Book.IdCategory;
                            nmCount.Value = billInfo.Count;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (UpdateBill() > 0)
            {
                MessageBox.Show("Sửa dữ liệu thành công.", "Thông báo");
            }
            else
            {
                MessageBox.Show("Sửa dữ liệu không thành công.", "Thông báo");
            }
            formBill_Load(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DeleteBill() > 0)
            {
                MessageBox.Show("Xóa dữ liệu thành công.", "Thông báo");
            }
            else
            {
                MessageBox.Show("Xóa dữ liệu không thành công.", "Thông báo");
            }
            formBill_Load(sender, e);
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            formBill_Load(sender, e);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (InsertBillInfo() > 0)
            {
                MessageBox.Show("Thêm dữ liệu thành công.", "Thông báo");
            }
            else
            {
                MessageBox.Show("Thêm dữ liệu không thành công.", "Thông báo");
            }
            UpdateTotalLabel();
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (DeleteBillInfo() > 0)
            {
                MessageBox.Show("Xóa dữ liệu thành công.", "Thông báo");
            }
            else
            {
                MessageBox.Show("Xóa dữ liệu không thành công.", "Thông báo");
            }
            UpdateTotalLabel();
        }

        private void btnUpdateBI_Click(object sender, EventArgs e)
        {
            if (UpdateBillInfo() > 0)
            {
                MessageBox.Show("Sửa dữ liệu thành công.", "Thông báo");
            }
            else
            {
                MessageBox.Show("Sửa dữ liệu không thành công.", "Thông báo");
            }
            UpdateTotalLabel();
        }

        private void cbCategory_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbCategory.SelectedValue != null && cbCategory.SelectedValue is int)
                {
                    var idCategory = (int)cbCategory.SelectedValue;
                    LoadBooksForCategory(idCategory);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
    }
}

