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
using System.Data.SqlClient;


namespace QuanLyDiem.GUI
{
    public partial class frmLopList : Form
    {
        public frmLopList()
        {
            InitializeComponent();
        }
        LopBLL bllLop;
        KhoaBLL bllKhoa = new KhoaBLL();
        public Action<object, EventArgs> Button_Clicked { get; private set; }

        public void LoadData()
        {
            bllLop = new LopBLL();
            List<Lop> list = new List<Lop>();
            List<Khoa> listKhoa = new List<Khoa>();
            try
            {
                
                list = bllLop.GetAll();
                dgvLopList.DataSource = list;
                
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
            frmLop frm = new frmLop();
            frm.Button_Clicked += CallLoadData;
            frm.Show();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Common.flag = 1;
            frmLop frm = new frmLop();
            string malop = dgvLopList.CurrentRow.Cells[0].Value.ToString();
            string tenlop = dgvLopList.CurrentRow.Cells[1].Value.ToString();
            string makhoa = dgvLopList.CurrentRow.Cells[2].Value.ToString();
            frm.GetData(malop, tenlop,makhoa);
            frm.Button_Clicked += CallLoadData;
            frm.Show();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Lop lop = new Lop();
            lop.MaLop = dgvLopList.CurrentRow.Cells[0].Value.ToString();
            LopBLL bllLop = new LopBLL();
            try
            {
                if (MessageBox.Show("bạn có chắc muốn xóa?", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (bllLop.Delete(lop))
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

        private void frmLopList_Load(object sender, EventArgs e)
        {
            
            LoadData();

            
        }
        
        private void cboKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {

            
            
        }
        
        
    }
}
