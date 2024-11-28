namespace baitaplon
{
    partial class Form1
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
            this.tpLoaimon = new System.Windows.Forms.FlowLayoutPanel();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgvLoaiMon = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnTimKiemLoaiMon = new System.Windows.Forms.Button();
            this.btnXoaLoaiMon = new System.Windows.Forms.Button();
            this.btnSuaLoaiMon = new System.Windows.Forms.Button();
            this.btnThemLoaiMon = new System.Windows.Forms.Button();
            this.txbTenLoai = new System.Windows.Forms.TextBox();
            this.txbMaLoai = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tpLoaimon.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLoaiMon)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpLoaimon
            // 
            this.tpLoaimon.BackColor = System.Drawing.Color.Moccasin;
            this.tpLoaimon.Controls.Add(this.label16);
            this.tpLoaimon.Controls.Add(this.groupBox2);
            this.tpLoaimon.Controls.Add(this.groupBox3);
            this.tpLoaimon.Controls.Add(this.comboBox1);
            this.tpLoaimon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpLoaimon.Location = new System.Drawing.Point(0, 24);
            this.tpLoaimon.Name = "tpLoaimon";
            this.tpLoaimon.Size = new System.Drawing.Size(953, 470);
            this.tpLoaimon.TabIndex = 0;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label16.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(2, 0);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(938, 38);
            this.label16.TabIndex = 1;
            this.label16.Text = "QUẢN LÝ LOẠI MÓN ĂN";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgvLoaiMon);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(2, 40);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(382, 440);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách loại món ăn";
            // 
            // dtgvLoaiMon
            // 
            this.dtgvLoaiMon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvLoaiMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvLoaiMon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dtgvLoaiMon.Location = new System.Drawing.Point(5, 27);
            this.dtgvLoaiMon.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvLoaiMon.Name = "dtgvLoaiMon";
            this.dtgvLoaiMon.RowHeadersWidth = 51;
            this.dtgvLoaiMon.RowTemplate.Height = 24;
            this.dtgvLoaiMon.Size = new System.Drawing.Size(368, 401);
            this.dtgvLoaiMon.TabIndex = 0;
            this.dtgvLoaiMon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvLoaiMon_CellContentClick);
            this.dtgvLoaiMon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvLoaiMon_CellContentClick_1);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MA_LOAI_MON";
            this.Column1.FillWeight = 50F;
            this.Column1.HeaderText = "Mã loại món";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TEN_LOAI_MON";
            this.Column2.HeaderText = "Tên loại món";
            this.Column2.Name = "Column2";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnTimKiemLoaiMon);
            this.groupBox3.Controls.Add(this.btnXoaLoaiMon);
            this.groupBox3.Controls.Add(this.btnSuaLoaiMon);
            this.groupBox3.Controls.Add(this.btnThemLoaiMon);
            this.groupBox3.Controls.Add(this.txbTenLoai);
            this.groupBox3.Controls.Add(this.txbMaLoai);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(388, 40);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(476, 180);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin loại món ăn";
            // 
            // btnTimKiemLoaiMon
            // 
            this.btnTimKiemLoaiMon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnTimKiemLoaiMon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemLoaiMon.Location = new System.Drawing.Point(344, 127);
            this.btnTimKiemLoaiMon.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimKiemLoaiMon.Name = "btnTimKiemLoaiMon";
            this.btnTimKiemLoaiMon.Size = new System.Drawing.Size(90, 32);
            this.btnTimKiemLoaiMon.TabIndex = 4;
            this.btnTimKiemLoaiMon.Text = "Tìm kiếm";
            this.btnTimKiemLoaiMon.UseVisualStyleBackColor = false;
            this.btnTimKiemLoaiMon.Click += new System.EventHandler(this.btnTimKiemLoaiMon_Click);
            // 
            // btnXoaLoaiMon
            // 
            this.btnXoaLoaiMon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnXoaLoaiMon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaLoaiMon.Location = new System.Drawing.Point(242, 127);
            this.btnXoaLoaiMon.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoaLoaiMon.Name = "btnXoaLoaiMon";
            this.btnXoaLoaiMon.Size = new System.Drawing.Size(90, 32);
            this.btnXoaLoaiMon.TabIndex = 4;
            this.btnXoaLoaiMon.Text = "Xóa";
            this.btnXoaLoaiMon.UseVisualStyleBackColor = false;
            this.btnXoaLoaiMon.Click += new System.EventHandler(this.btnXoaLoaiMon_Click);
            // 
            // btnSuaLoaiMon
            // 
            this.btnSuaLoaiMon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSuaLoaiMon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaLoaiMon.Location = new System.Drawing.Point(139, 127);
            this.btnSuaLoaiMon.Margin = new System.Windows.Forms.Padding(2);
            this.btnSuaLoaiMon.Name = "btnSuaLoaiMon";
            this.btnSuaLoaiMon.Size = new System.Drawing.Size(90, 32);
            this.btnSuaLoaiMon.TabIndex = 4;
            this.btnSuaLoaiMon.Text = "Sửa";
            this.btnSuaLoaiMon.UseVisualStyleBackColor = false;
            this.btnSuaLoaiMon.Click += new System.EventHandler(this.btnSuaLoaiMon_Click);
            // 
            // btnThemLoaiMon
            // 
            this.btnThemLoaiMon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnThemLoaiMon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemLoaiMon.Location = new System.Drawing.Point(33, 127);
            this.btnThemLoaiMon.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemLoaiMon.Name = "btnThemLoaiMon";
            this.btnThemLoaiMon.Size = new System.Drawing.Size(90, 32);
            this.btnThemLoaiMon.TabIndex = 4;
            this.btnThemLoaiMon.Text = "Thêm";
            this.btnThemLoaiMon.UseVisualStyleBackColor = false;
            this.btnThemLoaiMon.Click += new System.EventHandler(this.btnThemLoaiMon_Click);
            // 
            // txbTenLoai
            // 
            this.txbTenLoai.Location = new System.Drawing.Point(131, 80);
            this.txbTenLoai.Margin = new System.Windows.Forms.Padding(2);
            this.txbTenLoai.Name = "txbTenLoai";
            this.txbTenLoai.Size = new System.Drawing.Size(304, 26);
            this.txbTenLoai.TabIndex = 3;
            // 
            // txbMaLoai
            // 
            this.txbMaLoai.Location = new System.Drawing.Point(131, 40);
            this.txbMaLoai.Margin = new System.Windows.Forms.Padding(2);
            this.txbMaLoai.Name = "txbMaLoai";
            this.txbMaLoai.Size = new System.Drawing.Size(304, 26);
            this.txbMaLoai.TabIndex = 2;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(20, 81);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(99, 20);
            this.label18.TabIndex = 1;
            this.label18.Text = "Tên loại món";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(20, 41);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(94, 20);
            this.label17.TabIndex = 0;
            this.label17.Text = "Mã loại món";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 485);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(953, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 494);
            this.Controls.Add(this.tpLoaimon);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Loại món";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tpLoaimon.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLoaiMon)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel tpLoaimon;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgvLoaiMon;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnTimKiemLoaiMon;
        private System.Windows.Forms.Button btnXoaLoaiMon;
        private System.Windows.Forms.Button btnSuaLoaiMon;
        private System.Windows.Forms.Button btnThemLoaiMon;
        private System.Windows.Forms.TextBox txbTenLoai;
        private System.Windows.Forms.TextBox txbMaLoai;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}

