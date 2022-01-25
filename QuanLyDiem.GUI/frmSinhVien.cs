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
    public partial class frmSinhVien : Form
    {
        
        public frmSinhVien()
        {
            InitializeComponent();
            
            
        }
        SinhVienBLL bllSinhVien = new SinhVienBLL();
        SinhVien sv = new SinhVien();

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            
        }

        private void txtMaSV_TextChanged(object sender, EventArgs e)
        {

        }
        public event EventHandler Button_Clicked;
        
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaSV.Text != "" && txtHo.Text!="" && txtTenSV.Text != "" && txtMaLop.Text != "" && numPhai.Value.ToString() != "" && dtpNgaySinh.Value.ToString() != ""
                    && txtNoiSinh.Text != "" && txtDiaChi.Text != "" && numNghiHoc.Value.ToString() != "")
            {
                SinhVien sv = new SinhVien();                
                sv.MaSV = txtMaSV.Text;
                sv.Ho = txtTenSV.Text;
                sv.Ten = txtTenSV.Text;
                sv.MaLop = txtMaLop.Text;
                sv.Phai = bool.Parse(numPhai.Text);
                sv.NgaySinh = DateTime.Parse(dtpNgaySinh.Text);
                sv.NoiSinh = txtNoiSinh.Text;
                sv.DiaChi = txtDiaChi.Text;
                sv.NghiHoc = bool.Parse(numNghiHoc.Text);
                try
                {
                    if (Common.flag==0)
                    {
                        if (bllSinhVien.Insert(sv))
                        {
                            MessageBox.Show("Lưu thành công!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Lỗi khi lưu!", "Thông báo",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }    
                    }
                    else if (Common.flag==1)
                    {
                        if (bllSinhVien.Update(sv))
                        {
                            MessageBox.Show("Lưu thành công!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Lỗi khi lưu!", "Thông báo",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }    
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi:" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //Khi sự kiện xảy ra
                if (Button_Clicked != null)
                {
                    //Phát sinh sự kiện
                    Button_Clicked(sender, e);
                }
                
            }
        }
            
        public void GetData(string masv, string ho ,string ten, string malop, bool phai, DateTime ngaysinh,string noisinh, string diachi,bool nghihoc)
        {
            
            txtMaSV.Text = masv;
            txtHo.Text = ho;
            txtTenSV.Text = ten;
            txtMaLop.Text = malop;
            numPhai.Enabled = phai;
            dtpNgaySinh.Value = ngaysinh;
            txtNoiSinh.Text = noisinh;
            txtDiaChi.Text = diachi;
            numNghiHoc.Enabled = nghihoc;
        }
        
    }
}
