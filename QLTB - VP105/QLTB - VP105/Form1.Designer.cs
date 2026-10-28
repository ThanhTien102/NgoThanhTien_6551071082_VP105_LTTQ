namespace QLTB___VP105
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            txtDonGia = new TextBox();
            txtTenTB = new TextBox();
            txtMaTB = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnXoa = new Button();
            btnThoat = new Button();
            btnSua = new Button();
            btnThem = new Button();
            groupBox3 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtDonGia);
            groupBox1.Controls.Add(txtTenTB);
            groupBox1.Controls.Add(txtMaTB);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F);
            groupBox1.Location = new Point(528, 49);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(331, 199);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin thiết bị";
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(151, 149);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(151, 34);
            txtDonGia.TabIndex = 5;
            txtDonGia.TextChanged += txtDonGia_TextChanged;
            // 
            // txtTenTB
            // 
            txtTenTB.Location = new Point(151, 100);
            txtTenTB.Name = "txtTenTB";
            txtTenTB.Size = new Size(151, 34);
            txtTenTB.TabIndex = 4;
            // 
            // txtMaTB
            // 
            txtMaTB.Location = new Point(151, 43);
            txtMaTB.Name = "txtMaTB";
            txtMaTB.Size = new Size(151, 34);
            txtMaTB.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 149);
            label3.Name = "label3";
            label3.Size = new Size(143, 28);
            label3.TabIndex = 2;
            label3.Text = "Đơn giá (VND):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 100);
            label2.Name = "label2";
            label2.Size = new Size(112, 28);
            label2.TabIndex = 1;
            label2.Text = "Tên thiết bị:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 46);
            label1.Name = "label1";
            label1.Size = new Size(116, 28);
            label1.TabIndex = 0;
            label1.Text = "Mã thiết bị: ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnThoat);
            groupBox2.Controls.Add(btnSua);
            groupBox2.Controls.Add(btnThem);
            groupBox2.Font = new Font("Segoe UI", 12F);
            groupBox2.Location = new Point(528, 254);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(331, 190);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thao tác";
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(185, 100);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(117, 40);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(185, 35);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(117, 40);
            btnThoat.TabIndex = 3;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(32, 100);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(117, 40);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(32, 34);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(117, 41);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Font = new Font("Segoe UI", 12F);
            groupBox3.Location = new Point(26, 30);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(496, 414);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách thiết bị ";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 33);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(484, 375);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(881, 473);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox txtDonGia;
        private TextBox txtTenTB;
        private TextBox txtMaTB;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnXoa;
        private Button btnThoat;
        private Button btnSua;
        private Button btnThem;
        private DataGridView dataGridView1;
    }
}
