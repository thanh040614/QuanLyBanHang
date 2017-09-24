using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHangHoa.view
{
    public partial class ListNhanVien : Form
    {
        public ListNhanVien()
        {
            InitializeComponent();
        }

        private void ListNhanVien_Load(object sender, EventArgs e)
        {

        }
        

        void bingding()
        {
            txtMa.DataBindings.Clear();
            txtMa.DataBindings.Add("Text", dgvDanhSachNhanVien, "Ma_NV");
            txtHoTen.DataBindings.Clear();
            txtHoTen.DataBindings.Add("Text", dgvDanhSachNhanVien, "Ten_NV");
            dtNamSinh.DataBindings.Clear();
            dtNamSinh.DataBindings.Add("Text", dgvDanhSachNhanVien, "NS_NV");
            txtDienThoai.DataBindings.Clear();
            txtDienThoai.DataBindings.Add("Text", dgvDanhSachNhanVien, "DT_NV");
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dgvDanhSachNhanVien, "DiaChi_NV");
            dtNgayVaoLam.DataBindings.Clear();
            dtNgayVaoLam.DataBindings.Add("Text", dgvDanhSachNhanVien, "MaNV");
            cmbGioiTinh.DataBindings.Clear();
            cmbGioiTinh.DataBindings.Add("Text", dgvDanhSachNhanVien, "GT_NV");






        }
    }
}
