namespace DONGHODEOTAY
{
    partial class frmCTHoaDon
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
            button1 = new Button();
            button2 = new Button();
            groupBox1 = new GroupBox();
            txtthanhtoan = new TextBox();
            txtgiamgia = new TextBox();
            txtthanhtien = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            txtngay = new TextBox();
            txtnv = new TextBox();
            txtten = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            hienthi = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hienthi).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(721, 498);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "In hóa đơn";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(933, 498);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtthanhtoan);
            groupBox1.Controls.Add(txtgiamgia);
            groupBox1.Controls.Add(txtthanhtien);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtngay);
            groupBox1.Controls.Add(txtnv);
            groupBox1.Controls.Add(txtten);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 84);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(433, 376);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin hóa đơn ";
            // 
            // txtthanhtoan
            // 
            txtthanhtoan.Location = new Point(179, 293);
            txtthanhtoan.Name = "txtthanhtoan";
            txtthanhtoan.Size = new Size(223, 27);
            txtthanhtoan.TabIndex = 11;
            // 
            // txtgiamgia
            // 
            txtgiamgia.Location = new Point(179, 243);
            txtgiamgia.Name = "txtgiamgia";
            txtgiamgia.Size = new Size(223, 27);
            txtgiamgia.TabIndex = 10;
            // 
            // txtthanhtien
            // 
            txtthanhtien.Location = new Point(179, 195);
            txtthanhtien.Name = "txtthanhtien";
            txtthanhtien.Size = new Size(223, 27);
            txtthanhtien.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(25, 300);
            label7.Name = "label7";
            label7.Size = new Size(93, 20);
            label7.TabIndex = 8;
            label7.Text = "Thanh toán ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(25, 250);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 7;
            label6.Text = "Giảm giá ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(25, 202);
            label5.Name = "label5";
            label5.Size = new Size(88, 20);
            label5.TabIndex = 6;
            label5.Text = "Thành tiền ";
            // 
            // txtngay
            // 
            txtngay.Enabled = false;
            txtngay.Location = new Point(179, 146);
            txtngay.Name = "txtngay";
            txtngay.Size = new Size(223, 27);
            txtngay.TabIndex = 5;
            // 
            // txtnv
            // 
            txtnv.Enabled = false;
            txtnv.Location = new Point(179, 96);
            txtnv.Name = "txtnv";
            txtnv.Size = new Size(223, 27);
            txtnv.TabIndex = 4;
            // 
            // txtten
            // 
            txtten.Location = new Point(179, 48);
            txtten.Name = "txtten";
            txtten.Size = new Size(223, 27);
            txtten.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(25, 149);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 2;
            label4.Text = "Ngày tạo ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(25, 103);
            label3.Name = "label3";
            label3.Size = new Size(111, 20);
            label3.TabIndex = 1;
            label3.Text = "Nhân viên tạo ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(25, 55);
            label2.Name = "label2";
            label2.Size = new Size(122, 20);
            label2.TabIndex = 0;
            label2.Text = "Tên khách hàng ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(421, 28);
            label1.Name = "label1";
            label1.Size = new Size(183, 25);
            label1.TabIndex = 3;
            label1.Text = "CHI TIẾT HÓA ĐƠN ";
            // 
            // hienthi
            // 
            hienthi.BackgroundColor = SystemColors.ButtonHighlight;
            hienthi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            hienthi.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            hienthi.Location = new Point(472, 96);
            hienthi.Name = "hienthi";
            hienthi.RowHeadersWidth = 51;
            hienthi.Size = new Size(603, 364);
            hienthi.TabIndex = 4;
            // 
            // Column1
            // 
            Column1.HeaderText = "Mã hóa đơn ";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Tên sản phẩm ";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.HeaderText = "Số lượng ";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Đơn giá ";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // frmCTHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1087, 566);
            Controls.Add(hienthi);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "frmCTHoaDon";
            Text = "frmCTHoaDon";
            Load += frmCTHoaDon_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)hienthi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private GroupBox groupBox1;
        private TextBox txtngay;
        private TextBox txtnv;
        private TextBox txtten;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView hienthi;
        private TextBox txtthanhtoan;
        private TextBox txtgiamgia;
        private TextBox txtthanhtien;
        private Label label7;
        private Label label6;
        private Label label5;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}