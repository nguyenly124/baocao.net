namespace DONGHODEOTAY
{
    partial class frmHoaDon
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            Masp = new DataGridViewTextBoxColumn();
            Tensp = new DataGridViewTextBoxColumn();
            Soluong = new DataGridViewTextBoxColumn();
            Gia = new DataGridViewTextBoxColumn();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(205, 32);
            label1.Name = "label1";
            label1.Size = new Size(229, 28);
            label1.TabIndex = 0;
            label1.Text = "HÓA ĐƠN BÁN HÀNG ";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Masp, Tensp, Soluong, Gia });
            dataGridView1.Location = new Point(25, 74);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(601, 369);
            dataGridView1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(437, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(637, 655);
            panel1.TabIndex = 2;
            // 
            // Masp
            // 
            Masp.HeaderText = "Mã sản phẩm ";
            Masp.MinimumWidth = 6;
            Masp.Name = "Masp";
            Masp.ReadOnly = true;
            Masp.Width = 150;
            // 
            // Tensp
            // 
            Tensp.HeaderText = "Tên sản phẩm ";
            Tensp.MinimumWidth = 6;
            Tensp.Name = "Tensp";
            Tensp.ReadOnly = true;
            Tensp.Width = 150;
            // 
            // Soluong
            // 
            Soluong.HeaderText = "Số lượng ";
            Soluong.MinimumWidth = 6;
            Soluong.Name = "Soluong";
            Soluong.Width = 125;
            // 
            // Gia
            // 
            Gia.HeaderText = "Giá ";
            Gia.MinimumWidth = 6;
            Gia.Name = "Gia";
            Gia.Width = 125;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 461);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 2;
            label2.Text = "Tổng tiền ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 506);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 3;
            label3.Text = "Ngày lập ";
            // 
            // frmHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1075, 667);
            Controls.Add(panel1);
            Name = "frmHoaDon";
            Text = "frmHoaDon";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Panel panel1;
        private DataGridViewTextBoxColumn Masp;
        private DataGridViewTextBoxColumn Tensp;
        private DataGridViewTextBoxColumn Soluong;
        private DataGridViewTextBoxColumn Gia;
        private Label label3;
        private Label label2;
    }
}