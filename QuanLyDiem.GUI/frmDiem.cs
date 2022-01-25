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
    public partial class frmDiem : Form
    {
        public frmDiem()
        {
            InitializeComponent();
        }
        Diem diem = new Diem();
        DiemBLL bllDiem = new DiemBLL();
        public void LoadCboKhoa()
        {
            KhoaBLL bllKhoa = new KhoaBLL();
            List<Khoa> listKhoa = new List<Khoa>();
            listKhoa = bllKhoa.GetAll();
            cboKhoa.DataSource = listKhoa;
            cboKhoa.DisplayMember = "TenKh";
            cboKhoa.ValueMember = "MaKh";
        }
        private void LoadKhoa(object sender, EventArgs e)
        {
            KhoaBLL bllKhoa = new KhoaBLL();
            List<Khoa> listKhoa = new List<Khoa>();
            listKhoa = bllKhoa.GetAll();
            cboKhoa.DataSource = listKhoa;
            cboKhoa.DisplayMember = "TenKh";
            cboKhoa.ValueMember = "MaKh";
        }
        public event EventHandler Button_Clicked;
        private void frmDiem_Load(object sender, EventArgs e)
        {
            LoadCboKhoa();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaMonHoc.Text!="" && txtMaSV.Text!="" && numLanThi.Value.ToString()!="" && txtDiemThi.Text!="")
                {
                    diem.MaMH = txtMaMonHoc.Text;
                    diem.MaSV = txtMaSV.Text;
                    diem.Lan = int.Parse(numLanThi.Value.ToString());
                    diem.Diemthi = int.Parse(txtDiemThi.Text);
                    if (Common.flag==0)
                    {
                        if (bllDiem.Insert(diem))
                        {
                            MessageBox.Show("Thêm thành công!", "thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("lỗi khi lưu!", "thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }    
                    }
                    else
                    {
                        if(bllDiem.Update(diem))
                        {
                            MessageBox.Show("Lỗi khi sửa!", "thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }    
                        else
                        {
                            MessageBox.Show("Sửa thành công!", "thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }    
                    }    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi; " + ex.Message, "Thông báo");
            }
            //khi sự kiện xảy ra
            if (Button_Clicked != null)
            {
                Button_Clicked(sender, e);
            }
        }
        public void GetData(string mamonhoc, string masv, int lan, int diemthi)
        {
            txtMaMonHoc.Text = mamonhoc;
            txtMaSV.Text = masv;
            numLanThi.Value = lan;
           
        }
    }
}
