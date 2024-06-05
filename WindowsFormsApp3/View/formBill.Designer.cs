namespace WindowsFormsApp.View
{
    partial class formBill
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formBill));
            this.dataGridViewBill = new System.Windows.Forms.DataGridView();
            this.dataGridViewBillInfo = new System.Windows.Forms.DataGridView();
            this.btnAddBill = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnReload = new DevExpress.XtraEditors.SimpleButton();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.cbCategory = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbBookName = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.nmCount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddBook = new DevExpress.XtraEditors.SimpleButton();
            this.btnDeleteBook = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdateBI = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.dtDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.ckbPay = new System.Windows.Forms.CheckBox();
            this.btnFind = new DevExpress.XtraEditors.SimpleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txbIdBill = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbIdBillInfo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.reflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBillInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDate)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBill
            // 
            this.dataGridViewBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBill.Location = new System.Drawing.Point(12, 170);
            this.dataGridViewBill.Name = "dataGridViewBill";
            this.dataGridViewBill.Size = new System.Drawing.Size(366, 524);
            this.dataGridViewBill.TabIndex = 0;
            this.dataGridViewBill.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBill_CellClick);
            // 
            // dataGridViewBillInfo
            // 
            this.dataGridViewBillInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBillInfo.Location = new System.Drawing.Point(385, 232);
            this.dataGridViewBillInfo.Name = "dataGridViewBillInfo";
            this.dataGridViewBillInfo.Size = new System.Drawing.Size(418, 462);
            this.dataGridViewBillInfo.TabIndex = 1;
            this.dataGridViewBillInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBillInfo_CellClick);
            // 
            // btnAddBill
            // 
            this.btnAddBill.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBill.Appearance.Options.UseFont = true;
            this.btnAddBill.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddBill.ImageOptions.Image")));
            this.btnAddBill.Location = new System.Drawing.Point(12, 726);
            this.btnAddBill.Name = "btnAddBill";
            this.btnAddBill.Size = new System.Drawing.Size(128, 55);
            this.btnAddBill.TabIndex = 2;
            this.btnAddBill.Text = "Thêm hóa đơn";
            this.btnAddBill.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Appearance.Options.UseFont = true;
            this.btnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(146, 726);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(128, 55);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Sửa hóa đơn";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.Location = new System.Drawing.Point(280, 726);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(128, 55);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Xóa hóa đơn";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReload
            // 
            this.btnReload.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.Appearance.Options.UseFont = true;
            this.btnReload.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.Image")));
            this.btnReload.Location = new System.Drawing.Point(414, 726);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(128, 55);
            this.btnReload.TabIndex = 2;
            this.btnReload.Text = "Làm mới";
            this.btnReload.Click += new System.EventHandler(this.btnReLoad_Click);
            // 
            // btnExit
            // 
            this.btnExit.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Appearance.Options.UseFont = true;
            this.btnExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.Image")));
            this.btnExit.Location = new System.Drawing.Point(722, 10);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(81, 36);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Trở về";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cbCategory
            // 
            this.cbCategory.DisplayMember = "Text";
            this.cbCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCategory.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.ItemHeight = 17;
            this.cbCategory.Location = new System.Drawing.Point(482, 140);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(168, 23);
            this.cbCategory.TabIndex = 3;
            this.cbCategory.ValueMember = "0";
            this.cbCategory.SelectedValueChanged += new System.EventHandler(this.cbCategory_SelectedValueChanged);
            // 
            // cbBookName
            // 
            this.cbBookName.DisplayMember = "Text";
            this.cbBookName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbBookName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBookName.FormattingEnabled = true;
            this.cbBookName.ItemHeight = 17;
            this.cbBookName.Location = new System.Drawing.Point(482, 166);
            this.cbBookName.Name = "cbBookName";
            this.cbBookName.Size = new System.Drawing.Size(320, 23);
            this.cbBookName.TabIndex = 4;
            // 
            // nmCount
            // 
            this.nmCount.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmCount.Location = new System.Drawing.Point(748, 140);
            this.nmCount.Name = "nmCount";
            this.nmCount.Size = new System.Drawing.Size(54, 23);
            this.nmCount.TabIndex = 5;
            this.nmCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(388, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Thể loại:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(388, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên sách:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(656, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Số lượng:";
            // 
            // btnAddBook
            // 
            this.btnAddBook.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBook.Appearance.Options.UseFont = true;
            this.btnAddBook.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddBook.ImageOptions.Image")));
            this.btnAddBook.Location = new System.Drawing.Point(385, 196);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(128, 30);
            this.btnAddBook.TabIndex = 2;
            this.btnAddBook.Text = "Thêm sản phẩm";
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteBook.Appearance.Options.UseFont = true;
            this.btnDeleteBook.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteBook.ImageOptions.Image")));
            this.btnDeleteBook.Location = new System.Drawing.Point(530, 196);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(128, 30);
            this.btnDeleteBook.TabIndex = 2;
            this.btnDeleteBook.Text = "Xóa sản phẩm";
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // btnUpdateBI
            // 
            this.btnUpdateBI.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateBI.Appearance.Options.UseFont = true;
            this.btnUpdateBI.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateBI.ImageOptions.Image")));
            this.btnUpdateBI.Location = new System.Drawing.Point(674, 196);
            this.btnUpdateBI.Name = "btnUpdateBI";
            this.btnUpdateBI.Size = new System.Drawing.Size(128, 30);
            this.btnUpdateBI.TabIndex = 2;
            this.btnUpdateBI.Text = "Sửa sản phẩm";
            this.btnUpdateBI.Click += new System.EventHandler(this.btnUpdateBI_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ngày:";
            // 
            // dtDate
            // 
            // 
            // 
            // 
            this.dtDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtDate.ButtonDropDown.Visible = true;
            this.dtDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDate.Location = new System.Drawing.Point(67, 140);
            // 
            // 
            // 
            this.dtDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            this.dtDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtDate.MonthCalendar.DisplayMonth = new System.DateTime(2024, 6, 1, 0, 0, 0, 0);
            this.dtDate.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.dtDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtDate.MonthCalendar.TodayButtonVisible = true;
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(134, 23);
            this.dtDate.TabIndex = 8;
            this.dtDate.Value = new System.DateTime(2024, 6, 4, 14, 32, 59, 0);
            // 
            // ckbPay
            // 
            this.ckbPay.AutoSize = true;
            this.ckbPay.BackColor = System.Drawing.Color.Transparent;
            this.ckbPay.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbPay.Location = new System.Drawing.Point(257, 141);
            this.ckbPay.Name = "ckbPay";
            this.ckbPay.Size = new System.Drawing.Size(121, 20);
            this.ckbPay.TabIndex = 9;
            this.ckbPay.Text = "Đã thanh toán";
            this.ckbPay.UseVisualStyleBackColor = false;
            // 
            // btnFind
            // 
            this.btnFind.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnFind.ImageOptions.Image")));
            this.btnFind.Location = new System.Drawing.Point(208, 140);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(38, 23);
            this.btnFind.TabIndex = 10;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Mã hóa đơn:";
            // 
            // txbIdBill
            // 
            this.txbIdBill.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIdBill.Location = new System.Drawing.Point(127, 112);
            this.txbIdBill.Name = "txbIdBill";
            this.txbIdBill.ReadOnly = true;
            this.txbIdBill.Size = new System.Drawing.Size(251, 23);
            this.txbIdBill.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(388, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Mã chi tiết hóa đơn:";
            // 
            // txbIdBillInfo
            // 
            this.txbIdBillInfo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIdBillInfo.Location = new System.Drawing.Point(565, 111);
            this.txbIdBillInfo.Name = "txbIdBillInfo";
            this.txbIdBillInfo.ReadOnly = true;
            this.txbIdBillInfo.Size = new System.Drawing.Size(235, 23);
            this.txbIdBillInfo.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(548, 762);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tổng tiền:";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.ForeColor = System.Drawing.Color.Tomato;
            this.labelTotal.Location = new System.Drawing.Point(647, 758);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(22, 23);
            this.labelTotal.TabIndex = 14;
            this.labelTotal.Text = "0";
            // 
            // reflectionLabel1
            // 
            this.reflectionLabel1.BackColor = System.Drawing.Color.Transparent;
            this.reflectionLabel1.Location = new System.Drawing.Point(16, 12);
            this.reflectionLabel1.Name = "reflectionLabel1";
            this.reflectionLabel1.Size = new System.Drawing.Size(348, 70);
            this.reflectionLabel1.TabIndex = 15;
            this.reflectionLabel1.Text = "<b><font size=\"+20\">Quản lý<font color=\"#B02B2C\"> hóa đơn</font></font></b>";
            // 
            // formBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 796);
            this.Controls.Add(this.reflectionLabel1);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txbIdBillInfo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbIdBill);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.ckbPay);
            this.Controls.Add(this.dtDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nmCount);
            this.Controls.Add(this.cbBookName);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnUpdateBI);
            this.Controls.Add(this.btnDeleteBook);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAddBill);
            this.Controls.Add(this.dataGridViewBillInfo);
            this.Controls.Add(this.dataGridViewBill);
            this.Name = "formBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formBill";
            this.Load += new System.EventHandler(this.formBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBillInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBill;
        private System.Windows.Forms.DataGridView dataGridViewBillInfo;
        private DevExpress.XtraEditors.SimpleButton btnAddBill;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnReload;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbCategory;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbBookName;
        private System.Windows.Forms.NumericUpDown nmCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btnAddBook;
        private DevExpress.XtraEditors.SimpleButton btnDeleteBook;
        private DevExpress.XtraEditors.SimpleButton btnUpdateBI;
        private System.Windows.Forms.Label label4;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtDate;
        private System.Windows.Forms.CheckBox ckbPay;
        private DevExpress.XtraEditors.SimpleButton btnFind;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbIdBill;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbIdBillInfo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelTotal;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel1;
    }
}