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
    public partial class frmMonHoc : Form
    {
        MonHocBLL bllMonHoc = null;
        public frmMonHoc()
        {
            InitializeComponent();
        }
       
        
        public event EventHandler Button_Clicked;
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaMonHoc.Text != "" && txtTenMonHoc.Text != "")
            {
                bllMonHoc = new MonHocBLL();
                MonHoc monhoc = new MonHoc();
                monhoc.MaMH = txtMaMonHoc.Text;
                monhoc.TenMH = txtTenMonHoc.Text;
                try
                {
                    if (Common.flag == 0)
                    {
                        if (bllMonHoc.Insert(monhoc))
                        {
                            MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Lỗi khi lưu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (Common.flag == 1)
                    {
                        if (bllMonHoc.Update(monhoc))
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
                    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //Khi có sự kiện xảy ra
                if (Button_Clicked != null)
                {
                    //Phát sinh sự kiện
                    Button_Clicked(sender, e);
                }
            }
        }
        public void GetData(string mamonhoc, string tenmonhoc)
        {
            txtMaMonHoc.Text = mamonhoc;
            txtTenMonHoc.Text = tenmonhoc;
        }
    }
}
