namespace N18DCCN109_BACKUP_RESTORE
{
    partial class loginForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textTenSV = new System.Windows.Forms.TextBox();
            this.textTaiKhoan = new System.Windows.Forms.TextBox();
            this.textMatKhau = new System.Windows.Forms.TextBox();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.btnThoatLogin = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên server: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tài khoản: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu: ";
            // 
            // textTenSV
            // 
            this.textTenSV.Location = new System.Drawing.Point(108, 37);
            this.textTenSV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textTenSV.Name = "textTenSV";
            this.textTenSV.Size = new System.Drawing.Size(190, 20);
            this.textTenSV.TabIndex = 3;
            this.textTenSV.Text = "tuitentuan.com,3341";
            // 
            // textTaiKhoan
            // 
            this.textTaiKhoan.Location = new System.Drawing.Point(108, 68);
            this.textTaiKhoan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textTaiKhoan.Name = "textTaiKhoan";
            this.textTaiKhoan.Size = new System.Drawing.Size(190, 20);
            this.textTaiKhoan.TabIndex = 4;
            this.textTaiKhoan.Text = "huulong";
            // 
            // textMatKhau
            // 
            this.textMatKhau.Location = new System.Drawing.Point(108, 98);
            this.textMatKhau.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textMatKhau.Name = "textMatKhau";
            this.textMatKhau.Size = new System.Drawing.Size(190, 20);
            this.textMatKhau.TabIndex = 5;
            this.textMatKhau.Text = "123";
            this.textMatKhau.UseSystemPasswordChar = true;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(71, 157);
            this.btnDangNhap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(80, 19);
            this.btnDangNhap.TabIndex = 6;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnThoatLogin
            // 
            this.btnThoatLogin.Location = new System.Drawing.Point(200, 157);
            this.btnThoatLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThoatLogin.Name = "btnThoatLogin";
            this.btnThoatLogin.Size = new System.Drawing.Size(80, 19);
            this.btnThoatLogin.TabIndex = 7;
            this.btnThoatLogin.Text = "Thoát";
            this.btnThoatLogin.UseVisualStyleBackColor = true;
            this.btnThoatLogin.Click += new System.EventHandler(this.btnThoatLogin_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThoatLogin);
            this.groupBox1.Controls.Add(this.btnDangNhap);
            this.groupBox1.Controls.Add(this.textMatKhau);
            this.groupBox1.Controls.Add(this.textTaiKhoan);
            this.groupBox1.Controls.Add(this.textTenSV);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(110, 36);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(345, 206);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đăng nhập";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(206, 245);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 9;
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 322);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "loginForm";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textTenSV;
        private System.Windows.Forms.TextBox textTaiKhoan;
        private System.Windows.Forms.TextBox textMatKhau;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Button btnThoatLogin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblMessage;
    }
}

