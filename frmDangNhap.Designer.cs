namespace DONGHODEOTAY
{
    partial class frmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtten = new TextBox();
            txtmatkhau = new TextBox();
            btdangnhap = new Button();
            btthoat = new Button();
            txttaikhoan = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(114, 44);
            label1.Name = "label1";
            label1.Size = new Size(348, 38);
            label1.TabIndex = 0;
            label1.Text = "ĐĂNG NHẬP HỆ THỐNG ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(66, 152);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên đăng nhập ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(66, 209);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 2;
            label3.Text = "Mật khẩu ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(66, 269);
            label4.Name = "label4";
            label4.Size = new Size(111, 20);
            label4.TabIndex = 3;
            label4.Text = "Loại tài khoản ";
            // 
            // txtten
            // 
            txtten.Location = new Point(203, 145);
            txtten.Name = "txtten";
            txtten.Size = new Size(244, 27);
            txtten.TabIndex = 4;
            // 
            // txtmatkhau
            // 
            txtmatkhau.Location = new Point(203, 202);
            txtmatkhau.Name = "txtmatkhau";
            txtmatkhau.Size = new Size(244, 27);
            txtmatkhau.TabIndex = 5;
            // 
            // btdangnhap
            // 
            btdangnhap.Location = new Point(134, 365);
            btdangnhap.Name = "btdangnhap";
            btdangnhap.Size = new Size(94, 29);
            btdangnhap.TabIndex = 7;
            btdangnhap.Text = "Đăng nhập ";
            btdangnhap.UseVisualStyleBackColor = true;
            btdangnhap.Click += btdangnhap_Click;
            // 
            // btthoat
            // 
            btthoat.Location = new Point(353, 365);
            btthoat.Name = "btthoat";
            btthoat.Size = new Size(94, 29);
            btthoat.TabIndex = 8;
            btthoat.Text = "Thoát ";
            btthoat.UseVisualStyleBackColor = true;
            btthoat.Click += btthoat_Click;
            // 
            // txttaikhoan
            // 
            txttaikhoan.FormattingEnabled = true;
            txttaikhoan.Location = new Point(203, 261);
            txttaikhoan.Name = "txttaikhoan";
            txttaikhoan.Size = new Size(244, 28);
            txttaikhoan.TabIndex = 9;
            // 
            // frmDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(560, 471);
            Controls.Add(txttaikhoan);
            Controls.Add(btthoat);
            Controls.Add(btdangnhap);
            Controls.Add(txtmatkhau);
            Controls.Add(txtten);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmDangNhap";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtten;
        private TextBox txtmatkhau;
        private Button btdangnhap;
        private Button btthoat;
        private ComboBox txttaikhoan;
    }
}