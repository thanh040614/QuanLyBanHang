namespace QuanLyHangHoa.view
{
    partial class ListNhanVien
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
            this.gbThongTin = new System.Windows.Forms.GroupBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dtNamSinh = new System.Windows.Forms.DateTimePicker();
            this.cmbGioiTinh = new System.Windows.Forms.ComboBox();
            this.dtNgayVaoLam = new System.Windows.Forms.DateTimePicker();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.lblNamSinh = new System.Windows.Forms.Label();
            this.lblNgayBatDau = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblDienThoai = new System.Windows.Forms.Label();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachNhanVien = new System.Windows.Forms.DataGridView();
            this.MA_NV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEN_NV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NS_NV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GT_NV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DT_NV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYVAOLAM_NV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIACHI_NV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbThongTin.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // gbThongTin
            // 
            this.gbThongTin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbThongTin.Controls.Add(this.btnHuy);
            this.gbThongTin.Controls.Add(this.btnLuu);
            this.gbThongTin.Controls.Add(this.btnSua);
            this.gbThongTin.Controls.Add(this.btnXoa);
            this.gbThongTin.Controls.Add(this.btnThem);
            this.gbThongTin.Controls.Add(this.dtNamSinh);
            this.gbThongTin.Controls.Add(this.cmbGioiTinh);
            this.gbThongTin.Controls.Add(this.dtNgayVaoLam);
            this.gbThongTin.Controls.Add(this.txtDiaChi);
            this.gbThongTin.Controls.Add(this.txtHoTen);
            this.gbThongTin.Controls.Add(this.txtDienThoai);
            this.gbThongTin.Controls.Add(this.txtMa);
            this.gbThongTin.Controls.Add(this.lblNamSinh);
            this.gbThongTin.Controls.Add(this.lblNgayBatDau);
            this.gbThongTin.Controls.Add(this.lblGioiTinh);
            this.gbThongTin.Controls.Add(this.lblTenNV);
            this.gbThongTin.Controls.Add(this.lblDiaChi);
            this.gbThongTin.Controls.Add(this.lblDienThoai);
            this.gbThongTin.Controls.Add(this.lblMaNV);
            this.gbThongTin.Location = new System.Drawing.Point(6, 12);
            this.gbThongTin.Name = "gbThongTin";
            this.gbThongTin.Size = new System.Drawing.Size(772, 296);
            this.gbThongTin.TabIndex = 1;
            this.gbThongTin.TabStop = false;
            this.gbThongTin.Text = "Thông Tin Sinh Viên";
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnHuy.Location = new System.Drawing.Point(531, 151);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(88, 40);
            this.btnHuy.TabIndex = 12;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLuu.Location = new System.Drawing.Point(416, 151);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(88, 40);
            this.btnLuu.TabIndex = 12;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSua.Location = new System.Drawing.Point(303, 151);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(88, 40);
            this.btnSua.TabIndex = 12;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoa.Location = new System.Drawing.Point(200, 151);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(88, 40);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThem.Location = new System.Drawing.Point(92, 151);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(88, 40);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // dtNamSinh
            // 
            this.dtNamSinh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtNamSinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNamSinh.Location = new System.Drawing.Point(659, 24);
            this.dtNamSinh.Name = "dtNamSinh";
            this.dtNamSinh.Size = new System.Drawing.Size(104, 20);
            this.dtNamSinh.TabIndex = 11;
            // 
            // cmbGioiTinh
            // 
            this.cmbGioiTinh.FormattingEnabled = true;
            this.cmbGioiTinh.Items.AddRange(new object[] {
            "Nam ",
            "Nữ"});
            this.cmbGioiTinh.Location = new System.Drawing.Point(89, 70);
            this.cmbGioiTinh.Name = "cmbGioiTinh";
            this.cmbGioiTinh.Size = new System.Drawing.Size(89, 21);
            this.cmbGioiTinh.TabIndex = 10;
            // 
            // dtNgayVaoLam
            // 
            this.dtNgayVaoLam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtNgayVaoLam.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayVaoLam.Location = new System.Drawing.Point(659, 66);
            this.dtNgayVaoLam.Name = "dtNgayVaoLam";
            this.dtNgayVaoLam.Size = new System.Drawing.Size(104, 20);
            this.dtNgayVaoLam.TabIndex = 9;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.AllowDrop = true;
            this.txtDiaChi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDiaChi.Location = new System.Drawing.Point(186, 112);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(466, 20);
            this.txtDiaChi.TabIndex = 8;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHoTen.Location = new System.Drawing.Point(344, 72);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(142, 20);
            this.txtHoTen.TabIndex = 8;
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDienThoai.Location = new System.Drawing.Point(344, 24);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(142, 20);
            this.txtDienThoai.TabIndex = 8;
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(89, 25);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(89, 20);
            this.txtMa.TabIndex = 8;
            // 
            // lblNamSinh
            // 
            this.lblNamSinh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNamSinh.AutoSize = true;
            this.lblNamSinh.Location = new System.Drawing.Point(569, 29);
            this.lblNamSinh.Name = "lblNamSinh";
            this.lblNamSinh.Size = new System.Drawing.Size(53, 13);
            this.lblNamSinh.TabIndex = 1;
            this.lblNamSinh.Text = "Năm Sinh";
            // 
            // lblNgayBatDau
            // 
            this.lblNgayBatDau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNgayBatDau.AutoSize = true;
            this.lblNgayBatDau.Location = new System.Drawing.Point(569, 69);
            this.lblNgayBatDau.Name = "lblNgayBatDau";
            this.lblNgayBatDau.Size = new System.Drawing.Size(77, 13);
            this.lblNgayBatDau.TabIndex = 2;
            this.lblNgayBatDau.Text = "Ngày Vào Làm";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(38, 73);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(51, 13);
            this.lblGioiTinh.TabIndex = 3;
            this.lblGioiTinh.Text = "Giới Tính";
            // 
            // lblTenNV
            // 
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.Location = new System.Drawing.Point(279, 72);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(43, 13);
            this.lblTenNV.TabIndex = 4;
            this.lblTenNV.Text = "Họ Tên";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(139, 115);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(41, 13);
            this.lblDiaChi.TabIndex = 5;
            this.lblDiaChi.Text = "Địa Chỉ";
            // 
            // lblDienThoai
            // 
            this.lblDienThoai.AutoSize = true;
            this.lblDienThoai.Location = new System.Drawing.Point(279, 27);
            this.lblDienThoai.Name = "lblDienThoai";
            this.lblDienThoai.Size = new System.Drawing.Size(59, 13);
            this.lblDienThoai.TabIndex = 6;
            this.lblDienThoai.Text = "Điện Thoại";
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Location = new System.Drawing.Point(38, 29);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(36, 13);
            this.lblMaNV.TabIndex = 7;
            this.lblMaNV.Text = "Mã số";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDanhSachNhanVien);
            this.groupBox1.Location = new System.Drawing.Point(6, 297);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(766, 161);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Nhân Viên";
            // 
            // dgvDanhSachNhanVien
            // 
            this.dgvDanhSachNhanVien.AllowUserToAddRows = false;
            this.dgvDanhSachNhanVien.AllowUserToDeleteRows = false;
            this.dgvDanhSachNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MA_NV,
            this.TEN_NV,
            this.NS_NV,
            this.GT_NV,
            this.DT_NV,
            this.NGAYVAOLAM_NV,
            this.DIACHI_NV});
            this.dgvDanhSachNhanVien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDanhSachNhanVien.Location = new System.Drawing.Point(3, 33);
            this.dgvDanhSachNhanVien.Name = "dgvDanhSachNhanVien";
            this.dgvDanhSachNhanVien.ReadOnly = true;
            this.dgvDanhSachNhanVien.Size = new System.Drawing.Size(760, 125);
            this.dgvDanhSachNhanVien.TabIndex = 14;
            // 
            // MA_NV
            // 
            this.MA_NV.DataPropertyName = "MA_NV";
            this.MA_NV.HeaderText = "Mã nhân viên";
            this.MA_NV.Name = "MA_NV";
            this.MA_NV.ReadOnly = true;
            // 
            // TEN_NV
            // 
            this.TEN_NV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TEN_NV.DataPropertyName = "TEN_NV";
            this.TEN_NV.HeaderText = "Tên nhân viên";
            this.TEN_NV.Name = "TEN_NV";
            this.TEN_NV.ReadOnly = true;
            // 
            // NS_NV
            // 
            this.NS_NV.DataPropertyName = "NS_NV";
            this.NS_NV.HeaderText = "Năm sinh";
            this.NS_NV.Name = "NS_NV";
            this.NS_NV.ReadOnly = true;
            // 
            // GT_NV
            // 
            this.GT_NV.DataPropertyName = "GT_NV";
            this.GT_NV.HeaderText = "Giới tính";
            this.GT_NV.Name = "GT_NV";
            this.GT_NV.ReadOnly = true;
            // 
            // DT_NV
            // 
            this.DT_NV.DataPropertyName = "DT_NV";
            this.DT_NV.HeaderText = "Điện thoại";
            this.DT_NV.Name = "DT_NV";
            this.DT_NV.ReadOnly = true;
            // 
            // NGAYVAOLAM_NV
            // 
            this.NGAYVAOLAM_NV.DataPropertyName = "NGAYVAOLAM_NV";
            this.NGAYVAOLAM_NV.HeaderText = "Ngày vào làm";
            this.NGAYVAOLAM_NV.Name = "NGAYVAOLAM_NV";
            this.NGAYVAOLAM_NV.ReadOnly = true;
            // 
            // DIACHI_NV
            // 
            this.DIACHI_NV.DataPropertyName = "DIACHI_NV";
            this.DIACHI_NV.HeaderText = "Địa chỉ";
            this.DIACHI_NV.Name = "DIACHI_NV";
            this.DIACHI_NV.ReadOnly = true;
            // 
            // ListNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 470);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbThongTin);
            this.Name = "ListNhanVien";
            this.Text = "Quản Lý Nhân Viên";
            this.Load += new System.EventHandler(this.ListNhanVien_Load);
            this.gbThongTin.ResumeLayout(false);
            this.gbThongTin.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachNhanVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbThongTin;
        private System.Windows.Forms.Label lblNamSinh;
        private System.Windows.Forms.Label lblNgayBatDau;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblDienThoai;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.ComboBox cmbGioiTinh;
        private System.Windows.Forms.DateTimePicker dtNgayVaoLam;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DateTimePicker dtNamSinh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDanhSachNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MA_NV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEN_NV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NS_NV;
        private System.Windows.Forms.DataGridViewTextBoxColumn GT_NV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DT_NV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYVAOLAM_NV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIACHI_NV;
    }
}