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
    public partial class frmLop : Form
    {
          
        LopBLL bllLop = new LopBLL();
        Lop lop = new Lop();

        public event EventHandler Button_Clicked;

        public frmLop()
        {
            InitializeComponent();

        }
        
        private void btnThem_Click(object sender, EventArgs e)
        {
            frmLop frm = new frmLop();
            try
            {
                if (txtMaLop.Text != "" && txtTenLop.Text != "" && txtMaKhoa.Text!="")
                {
                    lop.MaLop = txtMaLop.Text;
                    lop.TenLop = txtTenLop.Text;
                    lop.MaKh = txtMaKhoa.Text;
                    if (Common.flag==0)
                    {
                        if (bllLop.Insert(lop))
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
                        if (bllLop.Update(lop))
                        {
                            if (bllLop.Insert(lop))
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
        public void GetData(string malop, string tenlop, string makhoa)
        {
            txtMaLop.Text = malop;
            txtTenLop.Text = tenlop;
            txtMaKhoa.Text = makhoa;
        }
        private void frmLop_Load(object sender, EventArgs e)
        {
            
        }

        
    }  
}
