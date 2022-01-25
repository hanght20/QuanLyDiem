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
using CrystalDecisions.CrystalReports.Engine;

namespace QuanLyDiem.GUI
{
    public partial class frmDanhSachSinhVienTheoLop : Form
    {

        public frmDanhSachSinhVienTheoLop()
        {
            InitializeComponent();
        }
       

        private void frmDanhSachSinhVien_Load(object sender, EventArgs e)
        {
            
        }

        private void btnIn_Click_1(object sender, EventArgs e)
        {

            SinhVienBLL bllSinhVien = new SinhVienBLL();
            DataTable table = new DataTable();


            try
            {
                table = bllSinhVien.GetDanhSachSinhVienTheoLop(txtMaLop.Text);
                Report.DanhSachSVTheoLop document = new Report.DanhSachSVTheoLop();
                document.SetDataSource(table);
                foreach (ReportObject item in document.ReportDefinition.ReportObjects)
                {
                    if (item is TextObject)
                    {
                        if (item.Name == "txtMaLop")
                        {
                            TextObject textObject = (TextObject)item;
                            textObject.Text = "Mã lớp: " + txtMaLop.Text;
                        }
                    }
                }
                crvDanhSachSVTheoLop.ReportSource = document;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
