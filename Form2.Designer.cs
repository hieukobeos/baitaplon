namespace baitaplon
{
    partial class Form2
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnReloadMon = new System.Windows.Forms.Button();
            this.btnXoaMon = new System.Windows.Forms.Button();
            this.btnSuaMon = new System.Windows.Forms.Button();
            this.btnThemMon = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnTimKiemMon = new System.Windows.Forms.Button();
            this.ckbTKDonGia = new System.Windows.Forms.CheckBox();
            this.ckbTKLoaiMon = new System.Windows.Forms.CheckBox();
            this.ckbTKTenMon = new System.Windows.Forms.CheckBox();
            this.label19 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.cbLoaiMon = new System.Windows.Forms.ComboBox();
            this.txbDonGia = new System.Windows.Forms.TextBox();
            this.txbDVT = new System.Windows.Forms.TextBox();
            this.txbTenMon = new System.Windows.Forms.TextBox();
            this.txbMaMon = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.dtgvMon = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label26 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMon)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel6);
            this.flowLayoutPanel1.Controls.Add(this.groupBox4);
            this.flowLayoutPanel1.Controls.Add(this.label19);
            this.flowLayoutPanel1.Controls.Add(this.panel8);
            this.flowLayoutPanel1.Controls.Add(this.panel9);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(5, 6);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1179, 502);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnReloadMon);
            this.panel6.Controls.Add(this.btnXoaMon);
            this.panel6.Controls.Add(this.btnSuaMon);
            this.panel6.Controls.Add(this.btnThemMon);
            this.panel6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel6.Location = new System.Drawing.Point(2, 2);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(437, 71);
            this.panel6.TabIndex = 6;
            // 
            // btnReloadMon
            // 
            this.btnReloadMon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnReloadMon.Location = new System.Drawing.Point(334, 24);
            this.btnReloadMon.Margin = new System.Windows.Forms.Padding(2);
            this.btnReloadMon.Name = "btnReloadMon";
            this.btnReloadMon.Size = new System.Drawing.Size(90, 32);
            this.btnReloadMon.TabIndex = 1;
            this.btnReloadMon.Text = "Tải lại";
            this.btnReloadMon.UseVisualStyleBackColor = false;
            this.btnReloadMon.Click += new System.EventHandler(this.btnReloadMon_Click);
            // 
            // btnXoaMon
            // 
            this.btnXoaMon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnXoaMon.Location = new System.Drawing.Point(229, 24);
            this.btnXoaMon.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoaMon.Name = "btnXoaMon";
            this.btnXoaMon.Size = new System.Drawing.Size(90, 32);
            this.btnXoaMon.TabIndex = 0;
            this.btnXoaMon.Text = "Xóa";
            this.btnXoaMon.UseVisualStyleBackColor = false;
            this.btnXoaMon.Click += new System.EventHandler(this.btnXoaMon_Click);
            // 
            // btnSuaMon
            // 
            this.btnSuaMon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSuaMon.Location = new System.Drawing.Point(124, 24);
            this.btnSuaMon.Margin = new System.Windows.Forms.Padding(2);
            this.btnSuaMon.Name = "btnSuaMon";
            this.btnSuaMon.Size = new System.Drawing.Size(90, 32);
            this.btnSuaMon.TabIndex = 0;
            this.btnSuaMon.Text = "Sửa";
            this.btnSuaMon.UseVisualStyleBackColor = false;
            this.btnSuaMon.Click += new System.EventHandler(this.btnSuaMon_Click);
            // 
            // btnThemMon
            // 
            this.btnThemMon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnThemMon.Location = new System.Drawing.Point(18, 24);
            this.btnThemMon.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.Size = new System.Drawing.Size(90, 32);
            this.btnThemMon.TabIndex = 0;
            this.btnThemMon.Text = "Thêm";
            this.btnThemMon.UseVisualStyleBackColor = false;
            this.btnThemMon.Click += new System.EventHandler(this.btnThemMon_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnTimKiemMon);
            this.groupBox4.Controls.Add(this.ckbTKDonGia);
            this.groupBox4.Controls.Add(this.ckbTKLoaiMon);
            this.groupBox4.Controls.Add(this.ckbTKTenMon);
            this.groupBox4.Location = new System.Drawing.Point(443, 2);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(666, 81);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tìm kiếm";
            // 
            // btnTimKiemMon
            // 
            this.btnTimKiemMon.Location = new System.Drawing.Point(441, 35);
            this.btnTimKiemMon.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimKiemMon.Name = "btnTimKiemMon";
            this.btnTimKiemMon.Size = new System.Drawing.Size(90, 32);
            this.btnTimKiemMon.TabIndex = 1;
            this.btnTimKiemMon.Text = "Tìm kiếm";
            this.btnTimKiemMon.UseVisualStyleBackColor = true;
            this.btnTimKiemMon.Click += new System.EventHandler(this.btnTimKiemMon_Click);
            // 
            // ckbTKDonGia
            // 
            this.ckbTKDonGia.AutoSize = true;
            this.ckbTKDonGia.Location = new System.Drawing.Point(260, 24);
            this.ckbTKDonGia.Margin = new System.Windows.Forms.Padding(2);
            this.ckbTKDonGia.Name = "ckbTKDonGia";
            this.ckbTKDonGia.Size = new System.Drawing.Size(63, 17);
            this.ckbTKDonGia.TabIndex = 2;
            this.ckbTKDonGia.Text = "Đơn giá";
            this.ckbTKDonGia.UseVisualStyleBackColor = true;
            // 
            // ckbTKLoaiMon
            // 
            this.ckbTKLoaiMon.AutoSize = true;
            this.ckbTKLoaiMon.Location = new System.Drawing.Point(78, 50);
            this.ckbTKLoaiMon.Margin = new System.Windows.Forms.Padding(2);
            this.ckbTKLoaiMon.Name = "ckbTKLoaiMon";
            this.ckbTKLoaiMon.Size = new System.Drawing.Size(69, 17);
            this.ckbTKLoaiMon.TabIndex = 1;
            this.ckbTKLoaiMon.Text = "Loại món";
            this.ckbTKLoaiMon.UseVisualStyleBackColor = true;
            // 
            // ckbTKTenMon
            // 
            this.ckbTKTenMon.AutoSize = true;
            this.ckbTKTenMon.Location = new System.Drawing.Point(78, 24);
            this.ckbTKTenMon.Margin = new System.Windows.Forms.Padding(2);
            this.ckbTKTenMon.Name = "ckbTKTenMon";
            this.ckbTKTenMon.Size = new System.Drawing.Size(68, 17);
            this.ckbTKTenMon.TabIndex = 0;
            this.ckbTKTenMon.Text = "Tên món";
            this.ckbTKTenMon.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label19.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(2, 85);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(1122, 38);
            this.label19.TabIndex = 1;
            this.label19.Text = "QUẢN LÝ MÓN ĂN";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.cbLoaiMon);
            this.panel8.Controls.Add(this.txbDonGia);
            this.panel8.Controls.Add(this.txbDVT);
            this.panel8.Controls.Add(this.txbTenMon);
            this.panel8.Controls.Add(this.txbMaMon);
            this.panel8.Controls.Add(this.label25);
            this.panel8.Controls.Add(this.label24);
            this.panel8.Controls.Add(this.label23);
            this.panel8.Controls.Add(this.label22);
            this.panel8.Controls.Add(this.label21);
            this.panel8.Controls.Add(this.label20);
            this.panel8.Location = new System.Drawing.Point(2, 125);
            this.panel8.Margin = new System.Windows.Forms.Padding(2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(437, 277);
            this.panel8.TabIndex = 3;
            // 
            // cbLoaiMon
            // 
            this.cbLoaiMon.FormattingEnabled = true;
            this.cbLoaiMon.Location = new System.Drawing.Point(100, 223);
            this.cbLoaiMon.Margin = new System.Windows.Forms.Padding(2);
            this.cbLoaiMon.Name = "cbLoaiMon";
            this.cbLoaiMon.Size = new System.Drawing.Size(299, 21);
            this.cbLoaiMon.TabIndex = 10;
            // 
            // txbDonGia
            // 
            this.txbDonGia.Location = new System.Drawing.Point(100, 184);
            this.txbDonGia.Margin = new System.Windows.Forms.Padding(2);
            this.txbDonGia.Name = "txbDonGia";
            this.txbDonGia.Size = new System.Drawing.Size(299, 20);
            this.txbDonGia.TabIndex = 9;
            // 
            // txbDVT
            // 
            this.txbDVT.Location = new System.Drawing.Point(100, 142);
            this.txbDVT.Margin = new System.Windows.Forms.Padding(2);
            this.txbDVT.Name = "txbDVT";
            this.txbDVT.Size = new System.Drawing.Size(299, 20);
            this.txbDVT.TabIndex = 8;
            // 
            // txbTenMon
            // 
            this.txbTenMon.Location = new System.Drawing.Point(100, 98);
            this.txbTenMon.Margin = new System.Windows.Forms.Padding(2);
            this.txbTenMon.Name = "txbTenMon";
            this.txbTenMon.Size = new System.Drawing.Size(299, 20);
            this.txbTenMon.TabIndex = 7;
            // 
            // txbMaMon
            // 
            this.txbMaMon.Location = new System.Drawing.Point(100, 58);
            this.txbMaMon.Margin = new System.Windows.Forms.Padding(2);
            this.txbMaMon.Name = "txbMaMon";
            this.txbMaMon.Size = new System.Drawing.Size(299, 20);
            this.txbMaMon.TabIndex = 6;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(19, 226);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(50, 13);
            this.label25.TabIndex = 5;
            this.label25.Text = "Loại món";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(19, 184);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(44, 13);
            this.label24.TabIndex = 4;
            this.label24.Text = "Đơn giá";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(19, 143);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(60, 13);
            this.label23.TabIndex = 3;
            this.label23.Text = "Đơn vị tính";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(19, 98);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(49, 13);
            this.label22.TabIndex = 2;
            this.label22.Text = "Tên món";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(19, 58);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(45, 13);
            this.label21.TabIndex = 1;
            this.label21.Text = "Mã món";
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.LightGray;
            this.label20.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(0, 8);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(437, 26);
            this.label20.TabIndex = 0;
            this.label20.Text = "Thông tin món ăn";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.dtgvMon);
            this.panel9.Controls.Add(this.label26);
            this.panel9.Location = new System.Drawing.Point(443, 125);
            this.panel9.Margin = new System.Windows.Forms.Padding(2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(681, 441);
            this.panel9.TabIndex = 5;
            // 
            // dtgvMon
            // 
            this.dtgvMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvMon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dtgvMon.Location = new System.Drawing.Point(17, 58);
            this.dtgvMon.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvMon.Name = "dtgvMon";
            this.dtgvMon.RowHeadersWidth = 51;
            this.dtgvMon.RowTemplate.Height = 24;
            this.dtgvMon.Size = new System.Drawing.Size(649, 406);
            this.dtgvMon.TabIndex = 1;
            this.dtgvMon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvMon_CellContentClick);
            this.dtgvMon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvMon_CellContentClick_1);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MA_MON";
            this.Column1.FillWeight = 25F;
            this.Column1.HeaderText = "Mã món";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MA_LOAI_MON";
            this.Column2.HeaderText = "Mã loại món";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TEN_MON";
            this.Column3.HeaderText = "Tên món";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "DON_VI";
            this.Column4.HeaderText = "Đơn vị tính";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "DON_GIA";
            this.Column5.HeaderText = "Đơn giá";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "TEN_LOAI_MON";
            this.Column6.HeaderText = "Tên loại món";
            this.Column6.Name = "Column6";
            // 
            // label26
            // 
            this.label26.BackColor = System.Drawing.Color.LightGray;
            this.label26.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(2, 0);
            this.label26.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(472, 26);
            this.label26.TabIndex = 0;
            this.label26.Text = "Danh sách món ăn";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 649);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form2";
            this.Text = "Món ăn";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnReloadMon;
        private System.Windows.Forms.Button btnXoaMon;
        private System.Windows.Forms.Button btnSuaMon;
        private System.Windows.Forms.Button btnThemMon;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnTimKiemMon;
        private System.Windows.Forms.CheckBox ckbTKDonGia;
        private System.Windows.Forms.CheckBox ckbTKLoaiMon;
        private System.Windows.Forms.CheckBox ckbTKTenMon;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.ComboBox cbLoaiMon;
        private System.Windows.Forms.TextBox txbDonGia;
        private System.Windows.Forms.TextBox txbDVT;
        private System.Windows.Forms.TextBox txbTenMon;
        private System.Windows.Forms.TextBox txbMaMon;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.DataGridView dtgvMon;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}