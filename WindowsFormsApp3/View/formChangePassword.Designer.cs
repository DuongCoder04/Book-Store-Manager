namespace WindowsFormsApp.View
{
    partial class formChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formChangePassword));
            this.panel1 = new System.Windows.Forms.Panel();
            this.reflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnReturn = new DevExpress.XtraEditors.SimpleButton();
            this.btnChange = new DevExpress.XtraEditors.SimpleButton();
            this.txbRenew = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbNewPw = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbCurrentPw = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.reflectionLabel1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnReturn);
            this.panel1.Controls.Add(this.btnChange);
            this.panel1.Controls.Add(this.txbRenew);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txbNewPw);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txbCurrentPw);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txbUserName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(16, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 475);
            this.panel1.TabIndex = 0;
            // 
            // reflectionLabel1
            // 
            this.reflectionLabel1.BackColor = System.Drawing.Color.Transparent;
            this.reflectionLabel1.Location = new System.Drawing.Point(60, 183);
            this.reflectionLabel1.Name = "reflectionLabel1";
            this.reflectionLabel1.Size = new System.Drawing.Size(254, 70);
            this.reflectionLabel1.TabIndex = 9;
            this.reflectionLabel1.Text = "<b><font size=\"+20\">Đổi<font color=\"#B02B2C\"> mật khẩu</font></font></b>";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp.Properties.Resources.user_149071;
            this.pictureBox1.Location = new System.Drawing.Point(110, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnReturn
            // 
            this.btnReturn.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Appearance.Options.UseFont = true;
            this.btnReturn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReturn.ImageOptions.Image")));
            this.btnReturn.Location = new System.Drawing.Point(191, 419);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(106, 40);
            this.btnReturn.TabIndex = 7;
            this.btnReturn.Text = "Trở lại";
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnChange
            // 
            this.btnChange.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.Appearance.Options.UseFont = true;
            this.btnChange.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnChange.ImageOptions.Image")));
            this.btnChange.Location = new System.Drawing.Point(75, 419);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(110, 40);
            this.btnChange.TabIndex = 6;
            this.btnChange.Text = "Cập nhật";
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // txbRenew
            // 
            this.txbRenew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbRenew.Location = new System.Drawing.Point(164, 370);
            this.txbRenew.Name = "txbRenew";
            this.txbRenew.Size = new System.Drawing.Size(195, 26);
            this.txbRenew.TabIndex = 3;
            this.txbRenew.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nhập lại:";
            // 
            // txbNewPw
            // 
            this.txbNewPw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNewPw.Location = new System.Drawing.Point(164, 338);
            this.txbNewPw.Name = "txbNewPw";
            this.txbNewPw.Size = new System.Drawing.Size(195, 26);
            this.txbNewPw.TabIndex = 3;
            this.txbNewPw.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu mới:";
            // 
            // txbCurrentPw
            // 
            this.txbCurrentPw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCurrentPw.Location = new System.Drawing.Point(164, 304);
            this.txbCurrentPw.Name = "txbCurrentPw";
            this.txbCurrentPw.Size = new System.Drawing.Size(195, 26);
            this.txbCurrentPw.TabIndex = 3;
            this.txbCurrentPw.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu hiện tại:";
            // 
            // txbUserName
            // 
            this.txbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUserName.Location = new System.Drawing.Point(164, 272);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.ReadOnly = true;
            this.txbUserName.Size = new System.Drawing.Size(195, 26);
            this.txbUserName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên người dùng:";
            // 
            // formChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(403, 513);
            this.Controls.Add(this.panel1);
            this.Name = "formChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formChangePassword";
            this.Load += new System.EventHandler(this.formChangePassword_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbCurrentPw;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbRenew;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbNewPw;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btnReturn;
        private DevExpress.XtraEditors.SimpleButton btnChange;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel1;
    }
}