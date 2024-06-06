namespace WindowsFormsApp
{
    partial class formMain
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
            this.ribbonControl1 = new DevComponents.DotNetBar.RibbonControl();
            this.ribbonPanel1 = new DevComponents.DotNetBar.RibbonPanel();
            this.rbExit = new DevComponents.DotNetBar.RibbonBar();
            this.btnExit = new DevComponents.DotNetBar.ButtonItem();
            this.rbUser = new DevComponents.DotNetBar.RibbonBar();
            this.btnUser = new DevComponents.DotNetBar.ButtonItem();
            this.rbChangePass = new DevComponents.DotNetBar.RibbonBar();
            this.btnChangePW = new DevComponents.DotNetBar.ButtonItem();
            this.rbLogout = new DevComponents.DotNetBar.RibbonBar();
            this.btnLogout = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonPanel2 = new DevComponents.DotNetBar.RibbonPanel();
            this.rbBill = new DevComponents.DotNetBar.RibbonBar();
            this.btnBill = new DevComponents.DotNetBar.ButtonItem();
            this.rbPublisher = new DevComponents.DotNetBar.RibbonBar();
            this.btnPublisher = new DevComponents.DotNetBar.ButtonItem();
            this.rbStaff = new DevComponents.DotNetBar.RibbonBar();
            this.btnStaff = new DevComponents.DotNetBar.ButtonItem();
            this.rbAuthors = new DevComponents.DotNetBar.RibbonBar();
            this.btnAuthors = new DevComponents.DotNetBar.ButtonItem();
            this.rbBook = new DevComponents.DotNetBar.RibbonBar();
            this.btnBook = new DevComponents.DotNetBar.ButtonItem();
            this.rbCategory = new DevComponents.DotNetBar.RibbonBar();
            this.btnCategory = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonTabItem1 = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonTabItem2 = new DevComponents.DotNetBar.RibbonTabItem();
            this.qatCustomizeItem1 = new DevComponents.DotNetBar.QatCustomizeItem();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ribbonControl1.SuspendLayout();
            this.ribbonPanel1.SuspendLayout();
            this.ribbonPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.BackColor = System.Drawing.Color.DarkSalmon;
            this.ribbonControl1.CaptionVisible = true;
            this.ribbonControl1.Controls.Add(this.ribbonPanel1);
            this.ribbonControl1.Controls.Add(this.ribbonPanel2);
            this.ribbonControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonControl1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ribbonTabItem1,
            this.ribbonTabItem2});
            this.ribbonControl1.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.ribbonControl1.Location = new System.Drawing.Point(4, 1);
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Office2007ColorTable = DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Black;
            this.ribbonControl1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.ribbonControl1.QuickToolbarItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.qatCustomizeItem1});
            this.ribbonControl1.Size = new System.Drawing.Size(1020, 154);
            this.ribbonControl1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonControl1.TabGroupHeight = 14;
            this.ribbonControl1.TabIndex = 0;
            this.ribbonControl1.Text = "ribbonControl1";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonPanel1.Controls.Add(this.rbExit);
            this.ribbonPanel1.Controls.Add(this.rbUser);
            this.ribbonPanel1.Controls.Add(this.rbChangePass);
            this.ribbonPanel1.Controls.Add(this.rbLogout);
            this.ribbonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel1.Location = new System.Drawing.Point(0, 55);
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel1.Size = new System.Drawing.Size(1020, 97);
            this.ribbonPanel1.TabIndex = 1;
            // 
            // rbExit
            // 
            this.rbExit.AutoOverflowEnabled = true;
            this.rbExit.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbExit.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbExit.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnExit});
            this.rbExit.Location = new System.Drawing.Point(222, 0);
            this.rbExit.Name = "rbExit";
            this.rbExit.Size = new System.Drawing.Size(73, 94);
            this.rbExit.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.rbExit.TabIndex = 3;
            this.rbExit.Text = "Thoát";
            // 
            // btnExit
            // 
            this.btnExit.Image = global::WindowsFormsApp.Properties.Resources.close_1828666__Custom_;
            this.btnExit.ImagePaddingHorizontal = 8;
            this.btnExit.Name = "btnExit";
            this.btnExit.SubItemsExpandWidth = 14;
            this.btnExit.Text = "Thoát";
            this.btnExit.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // rbUser
            // 
            this.rbUser.AutoOverflowEnabled = true;
            this.rbUser.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbUser.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbUser.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnUser});
            this.rbUser.Location = new System.Drawing.Point(149, 0);
            this.rbUser.Name = "rbUser";
            this.rbUser.Size = new System.Drawing.Size(73, 94);
            this.rbUser.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.rbUser.TabIndex = 2;
            this.rbUser.Text = "Người dùng";
            // 
            // btnUser
            // 
            this.btnUser.Image = global::WindowsFormsApp.Properties.Resources.user_149071__Custom_;
            this.btnUser.ImagePaddingHorizontal = 8;
            this.btnUser.Name = "btnUser";
            this.btnUser.SubItemsExpandWidth = 14;
            this.btnUser.Text = "Người dùng";
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // rbChangePass
            // 
            this.rbChangePass.AutoOverflowEnabled = true;
            this.rbChangePass.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbChangePass.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbChangePass.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnChangePW});
            this.rbChangePass.Location = new System.Drawing.Point(76, 0);
            this.rbChangePass.Name = "rbChangePass";
            this.rbChangePass.Size = new System.Drawing.Size(73, 94);
            this.rbChangePass.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.rbChangePass.TabIndex = 1;
            this.rbChangePass.Text = "Đổi mật khẩu";
            // 
            // btnChangePW
            // 
            this.btnChangePW.Image = global::WindowsFormsApp.Properties.Resources.password_13222412__Custom_;
            this.btnChangePW.ImagePaddingHorizontal = 8;
            this.btnChangePW.Name = "btnChangePW";
            this.btnChangePW.SubItemsExpandWidth = 14;
            this.btnChangePW.Text = "buttonItem1";
            this.btnChangePW.Click += new System.EventHandler(this.btnChangePW_Click);
            // 
            // rbLogout
            // 
            this.rbLogout.AutoOverflowEnabled = true;
            this.rbLogout.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbLogout.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLogout.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnLogout});
            this.rbLogout.Location = new System.Drawing.Point(3, 0);
            this.rbLogout.Name = "rbLogout";
            this.rbLogout.Size = new System.Drawing.Size(73, 94);
            this.rbLogout.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.rbLogout.TabIndex = 0;
            this.rbLogout.Text = "Đăng xuất";
            // 
            // btnLogout
            // 
            this.btnLogout.Image = global::WindowsFormsApp.Properties.Resources.Logout;
            this.btnLogout.ImagePaddingHorizontal = 8;
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.SubItemsExpandWidth = 14;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonPanel2.Controls.Add(this.rbBill);
            this.ribbonPanel2.Controls.Add(this.rbPublisher);
            this.ribbonPanel2.Controls.Add(this.rbStaff);
            this.ribbonPanel2.Controls.Add(this.rbAuthors);
            this.ribbonPanel2.Controls.Add(this.rbBook);
            this.ribbonPanel2.Controls.Add(this.rbCategory);
            this.ribbonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel2.Location = new System.Drawing.Point(0, 55);
            this.ribbonPanel2.Name = "ribbonPanel2";
            this.ribbonPanel2.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel2.Size = new System.Drawing.Size(1020, 97);
            this.ribbonPanel2.TabIndex = 2;
            this.ribbonPanel2.Visible = false;
            // 
            // rbBill
            // 
            this.rbBill.AutoOverflowEnabled = true;
            this.rbBill.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbBill.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnBill});
            this.rbBill.Location = new System.Drawing.Point(368, 0);
            this.rbBill.Name = "rbBill";
            this.rbBill.Size = new System.Drawing.Size(73, 94);
            this.rbBill.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.rbBill.TabIndex = 5;
            this.rbBill.Text = "Hóa đơn";
            // 
            // btnBill
            // 
            this.btnBill.Image = global::WindowsFormsApp.Properties.Resources.bill_6295902__Custom_;
            this.btnBill.ImagePaddingHorizontal = 8;
            this.btnBill.Name = "btnBill";
            this.btnBill.SubItemsExpandWidth = 14;
            this.btnBill.Text = "Bill";
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // rbPublisher
            // 
            this.rbPublisher.AutoOverflowEnabled = true;
            this.rbPublisher.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbPublisher.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnPublisher});
            this.rbPublisher.Location = new System.Drawing.Point(295, 0);
            this.rbPublisher.Name = "rbPublisher";
            this.rbPublisher.Size = new System.Drawing.Size(73, 94);
            this.rbPublisher.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.rbPublisher.TabIndex = 4;
            this.rbPublisher.Text = "Nhà xuất bản";
            // 
            // btnPublisher
            // 
            this.btnPublisher.Image = global::WindowsFormsApp.Properties.Resources.Publisher;
            this.btnPublisher.ImagePaddingHorizontal = 8;
            this.btnPublisher.Name = "btnPublisher";
            this.btnPublisher.SubItemsExpandWidth = 14;
            this.btnPublisher.Text = "Nhà xuất bản";
            this.btnPublisher.Click += new System.EventHandler(this.btnPublisher_Click);
            // 
            // rbStaff
            // 
            this.rbStaff.AutoOverflowEnabled = true;
            this.rbStaff.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbStaff.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnStaff});
            this.rbStaff.Location = new System.Drawing.Point(222, 0);
            this.rbStaff.Name = "rbStaff";
            this.rbStaff.Size = new System.Drawing.Size(73, 94);
            this.rbStaff.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.rbStaff.TabIndex = 3;
            this.rbStaff.Text = "Nhân viên";
            // 
            // btnStaff
            // 
            this.btnStaff.Image = global::WindowsFormsApp.Properties.Resources.Staff;
            this.btnStaff.ImagePaddingHorizontal = 8;
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.SubItemsExpandWidth = 14;
            this.btnStaff.Text = "Nhân viên";
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // rbAuthors
            // 
            this.rbAuthors.AutoOverflowEnabled = true;
            this.rbAuthors.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbAuthors.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnAuthors});
            this.rbAuthors.Location = new System.Drawing.Point(149, 0);
            this.rbAuthors.Name = "rbAuthors";
            this.rbAuthors.Size = new System.Drawing.Size(73, 94);
            this.rbAuthors.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.rbAuthors.TabIndex = 2;
            this.rbAuthors.Text = "Tác giả";
            // 
            // btnAuthors
            // 
            this.btnAuthors.Image = global::WindowsFormsApp.Properties.Resources.Authors;
            this.btnAuthors.ImagePaddingHorizontal = 8;
            this.btnAuthors.Name = "btnAuthors";
            this.btnAuthors.SubItemsExpandWidth = 14;
            this.btnAuthors.Text = "Tác giả";
            this.btnAuthors.Click += new System.EventHandler(this.btnAuthors_Click);
            // 
            // rbBook
            // 
            this.rbBook.AutoOverflowEnabled = true;
            this.rbBook.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbBook.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnBook});
            this.rbBook.Location = new System.Drawing.Point(76, 0);
            this.rbBook.Name = "rbBook";
            this.rbBook.Size = new System.Drawing.Size(73, 94);
            this.rbBook.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.rbBook.TabIndex = 1;
            this.rbBook.Text = "Sách";
            // 
            // btnBook
            // 
            this.btnBook.Image = global::WindowsFormsApp.Properties.Resources.Book;
            this.btnBook.ImagePaddingHorizontal = 8;
            this.btnBook.Name = "btnBook";
            this.btnBook.SubItemsExpandWidth = 14;
            this.btnBook.Text = "Sách";
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // rbCategory
            // 
            this.rbCategory.AutoOverflowEnabled = true;
            this.rbCategory.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbCategory.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbCategory.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnCategory});
            this.rbCategory.Location = new System.Drawing.Point(3, 0);
            this.rbCategory.Name = "rbCategory";
            this.rbCategory.Size = new System.Drawing.Size(73, 94);
            this.rbCategory.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.rbCategory.TabIndex = 0;
            this.rbCategory.Text = "Thể loại";
            // 
            // btnCategory
            // 
            this.btnCategory.Image = global::WindowsFormsApp.Properties.Resources.Category_icon;
            this.btnCategory.ImagePaddingHorizontal = 8;
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.SubItemsExpandWidth = 14;
            this.btnCategory.Text = "Thể loại";
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // ribbonTabItem1
            // 
            this.ribbonTabItem1.Checked = true;
            this.ribbonTabItem1.ImagePaddingHorizontal = 8;
            this.ribbonTabItem1.Name = "ribbonTabItem1";
            this.ribbonTabItem1.Panel = this.ribbonPanel1;
            this.ribbonTabItem1.Text = "Hệ thống";
            // 
            // ribbonTabItem2
            // 
            this.ribbonTabItem2.ImagePaddingHorizontal = 8;
            this.ribbonTabItem2.Name = "ribbonTabItem2";
            this.ribbonTabItem2.Panel = this.ribbonPanel2;
            this.ribbonTabItem2.Text = "Danh mục";
            // 
            // qatCustomizeItem1
            // 
            this.qatCustomizeItem1.Name = "qatCustomizeItem1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(24)))), ((int)(((byte)(66)))));
            this.label5.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(197)))));
            this.label5.Location = new System.Drawing.Point(581, 463);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(297, 32);
            this.label5.TabIndex = 1;
            this.label5.Text = "Giáo Viên Hướng Dẫn:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(24)))), ((int)(((byte)(66)))));
            this.label7.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(197)))));
            this.label7.Location = new System.Drawing.Point(594, 510);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(261, 31);
            this.label7.TabIndex = 2;
            this.label7.Text = "Thầy Giáo: Đặng Bảy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(24)))), ((int)(((byte)(66)))));
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(197)))));
            this.label3.Location = new System.Drawing.Point(157, 510);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nguyễn Văn Dưỡng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(24)))), ((int)(((byte)(66)))));
            this.label2.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(197)))));
            this.label2.Location = new System.Drawing.Point(134, 463);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Học Viên Thực Hiện:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(24)))), ((int)(((byte)(66)))));
            this.label6.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(197)))));
            this.label6.Location = new System.Drawing.Point(180, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(661, 55);
            this.label6.TabIndex = 5;
            this.label6.Text = "LẬP TRÌNH CƠ SỞ DỮ LIỆU";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(24)))), ((int)(((byte)(66)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(197)))));
            this.label1.Location = new System.Drawing.Point(267, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(486, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "Phần Mềm Quản Lý Cửa Hàng Sách\r\n";
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp.Properties.Resources._5328260;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1028, 686);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "formMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Books Store Manager";
            this.Load += new System.EventHandler(this.formMain_Load);
            this.ribbonControl1.ResumeLayout(false);
            this.ribbonControl1.PerformLayout();
            this.ribbonPanel1.ResumeLayout(false);
            this.ribbonPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.RibbonControl ribbonControl1;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel2;
        private DevComponents.DotNetBar.RibbonBar rbAuthors;
        private DevComponents.DotNetBar.RibbonBar rbBook;
        private DevComponents.DotNetBar.ButtonItem btnBook;
        private DevComponents.DotNetBar.RibbonBar rbCategory;
        private DevComponents.DotNetBar.ButtonItem btnCategory;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel1;
        private DevComponents.DotNetBar.RibbonBar rbLogout;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabItem1;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabItem2;
        private DevComponents.DotNetBar.QatCustomizeItem qatCustomizeItem1;
        private DevComponents.DotNetBar.ButtonItem btnAuthors;
        private DevComponents.DotNetBar.ButtonItem btnLogout;
        private DevComponents.DotNetBar.RibbonBar rbPublisher;
        private DevComponents.DotNetBar.ButtonItem btnPublisher;
        private DevComponents.DotNetBar.RibbonBar rbStaff;
        private DevComponents.DotNetBar.ButtonItem btnStaff;
        private DevComponents.DotNetBar.RibbonBar rbChangePass;
        private DevComponents.DotNetBar.ButtonItem btnChangePW;
        private DevComponents.DotNetBar.RibbonBar rbExit;
        private DevComponents.DotNetBar.ButtonItem btnExit;
        private DevComponents.DotNetBar.RibbonBar rbUser;
        private DevComponents.DotNetBar.ButtonItem btnUser;
        private DevComponents.DotNetBar.RibbonBar rbBill;
        private DevComponents.DotNetBar.ButtonItem btnBill;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
    }
}

