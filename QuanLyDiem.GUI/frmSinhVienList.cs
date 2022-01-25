using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyDiem.BLL;
using QuanLyDiem.DTO;
using QuanLyDiem.UTIL;

namespace QuanLyDiem.GUI
{
    public partial class frmSinhVienList : Form
    {
        public frmSinhVienList()
        {
            InitializeComponent();
        }
        SinhVienBLL bllSinhVien;


        public Action<object, EventArgs> Button_Clicked { get; private set; }

        public void LoadData()
        {
            KhoaBLL bllKhoa = new KhoaBLL();
            List<Khoa> listKhoa = new List<Khoa>();
            listKhoa = bllKhoa.GetAll();
            bllSinhVien = new SinhVienBLL();
            List<SinhVien> list = new List<SinhVien>();
            try
            {

                list = bllSinhVien.GetAll();
                dgvSinhVienList.DataSource = list;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void CallLoadData(object sender, EventArgs e)
        {
            LoadData();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            Common.flag = 0;
            frmSinhVien frm = new frmSinhVien();
            
            frm.Button_Clicked += CallLoadData;
            frm.Show();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Common.flag = 1;
            frmSinhVien frm = new frmSinhVien();
            string masv = dgvSinhVienList.CurrentRow.Cells[0].Value.ToString();
            string ho = dgvSinhVienList.CurrentRow.Cells[1].Value.ToString();
            string ten = dgvSinhVienList.CurrentRow.Cells[2].Value.ToString();
            string malop = dgvSinhVienList.CurrentRow.Cells[3].Value.ToString();
            bool phai = bool.Parse(dgvSinhVienList.CurrentRow.Cells[4].Value.ToString());
            DateTime ngaysinh = DateTime.Parse( dgvSinhVienList.CurrentRow.Cells[5].Value.ToString());
            string noisinh= dgvSinhVienList.CurrentRow.Cells[6].Value.ToString();
            string diachi = dgvSinhVienList.CurrentRow.Cells[7].Value.ToString();
            bool nghihoc = bool.Parse( dgvSinhVienList.CurrentRow.Cells[8].Value.ToString());
            frm.GetData(masv,ho, ten, malop, phai, ngaysinh, noisinh,diachi, nghihoc);
            frm.Button_Clicked += CallLoadData;
            frm.Show();
        }

        

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SinhVien sv = new SinhVien();
            sv.MaSV = dgvSinhVienList.CurrentRow.Cells[0].Value.ToString();
            SinhVienBLL bllSinhVien = new SinhVienBLL();
            try
            {
                if (MessageBox.Show("bạn có chắc muốn xóa?", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (bllSinhVien.Delete(sv))
                    {
                        MessageBox.Show("xóa thành công!", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            LoadData();
        }

        private void frmSinhVienList_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
