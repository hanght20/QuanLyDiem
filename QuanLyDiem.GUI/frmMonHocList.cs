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
    public partial class frmMonHocList : Form
    {
        public frmMonHocList()
        {
            InitializeComponent();
        }
        MonHocBLL bllMonHoc =null;
        private void btnThem_Click(object sender, EventArgs e)
        {
            Common.flag = 0;
            frmMonHoc frm = new frmMonHoc();
            frm.Button_Clicked += CallLoadData;
            frm.Show();
        }
        public void CallLoadData(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            bllMonHoc = new MonHocBLL();
            List<MonHoc> list = new List<MonHoc>();
            try
            {
                list = bllMonHoc.GetAll();
                dgvMonHocList.DataSource = list;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Common.flag = 1;
            frmMonHoc frm = new frmMonHoc();
            string mamonhoc = dgvMonHocList.CurrentRow.Cells[0].Value.ToString();
            string tenmonhoc = dgvMonHocList.CurrentRow.Cells[1].Value.ToString();
            frm.GetData(mamonhoc, tenmonhoc);
            frm.Button_Clicked += CallLoadData;
            frm.Show();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            MonHoc monhoc = new MonHoc();
            monhoc.MaMH = dgvMonHocList.CurrentRow.Cells[0].Value.ToString();
            MonHocBLL bllMonHoc = new MonHocBLL();
            try
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa ? ", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (bllMonHoc.Delete(monhoc))
                    {
                        MessageBox.Show("Xóa thành công!", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            LoadData();
        }

        private void frmMonHocList_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
