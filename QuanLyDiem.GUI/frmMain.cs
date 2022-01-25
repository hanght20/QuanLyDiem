using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiem.GUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmDangNhap frm = new frmDangNhap();
            frm.ShowDialog();
        }

        private void mnuDanhMuc_Click(object sender, EventArgs e)
        {

        }

        private void mnuLop_Click(object sender, EventArgs e)
        {
            frmLopList frm = new frmLopList();
            frm.Show();
        }

        private void mnuMonHoc_Click(object sender, EventArgs e)
        {
            frmMonHocList frm = new frmMonHocList();
            frm.Show();
        }

        private void mnuSinhVien_Click(object sender, EventArgs e)
        {
            frmSinhVienList frm = new frmSinhVienList();
            frm.Show();
        }

        private void mnuDiem_Click(object sender, EventArgs e)
        {
            frmDiem frm = new frmDiem();
            frm.Show();

        }

       

        private void danhSáchSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDanhSachSinhVienTheoLop frm = new frmDanhSachSinhVienTheoLop();
            frm.Show();
        }

        private void mnuPhieuDiem_Click(object sender, EventArgs e)
        {
            frmPhieuDiem frm = new frmPhieuDiem();
            frm.Show();
        }

        private void mnuPhieudiemThi_Click(object sender, EventArgs e)
        {
            frmPhieuDiemThi frm = new frmPhieuDiemThi();
                frm.Show();

        }

        private void bảngĐiểmMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBangDiemMonHoc frm = new frmBangDiemMonHoc();
            frm.Show();
        }

        private void bảngĐiểmTổngKếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBangDiemTongKet frm = new frmBangDiemTongKet();
            frm.Show();
        }
    }
}
