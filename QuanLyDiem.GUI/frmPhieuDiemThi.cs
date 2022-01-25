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
    public partial class frmPhieuDiemThi : Form
    {
        public frmPhieuDiemThi()
        {
            InitializeComponent();
        }

        private void txtTenLop_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            DiemBLL bllDiem = new DiemBLL();
            SinhVienBLL bllSinhVien = new SinhVienBLL();
            DataTable table = new DataTable();
            try
            {
                table = bllDiem.GetPhieuDiemThi(txtTenLop.Text,txtTenMonHoc.Text, int.Parse(txtLan.Text));
                Report.PhieuDiemThi document = new Report.PhieuDiemThi();
                document.SetDataSource(table);
                foreach (ReportObject item in document.ReportDefinition.ReportObjects)
                {
                    if (item is TextObject)
                    {
                        if (item.Name == "txtTenLop")
                        {
                            TextObject textObject = (TextObject)item;
                            textObject.Text = "Tên lớp: " + txtTenLop.Text;
                        }
                        else 
                        
                            if(item.Name=="txtTenMonHoc")
                            {
                                TextObject textObject = (TextObject)item;
                                textObject.Text = "Tên môn học: " + txtTenMonHoc.Text;
                            }    
                         
                        else
                        {
                            if(item.Name == "txtLan")
                            {
                                TextObject textObject = (TextObject)item;
                                textObject.Text = "Lần: " + txtLan.Text;
                            }
                        }
                    }
                }
                crvPhieuDiemThi.ReportSource = document;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
