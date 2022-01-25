using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using QuanLyDiem.BLL;
using QuanLyDiem.DTO;

namespace QuanLyDiem.GUI
{
    public partial class frmBangDiemMonHoc : Form
    {
        public frmBangDiemMonHoc()
        {
            InitializeComponent();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            DiemBLL bllDiem = new DiemBLL();
            DataTable table = new DataTable();
            try
            {
                table = bllDiem.GetBangDiemMonHoc(txtTenLop.Text);
                Report.BangDiemMonHoc document = new Report.BangDiemMonHoc();
                document.SetDataSource(table);
                foreach (ReportObject item in document.ReportDefinition.ReportObjects)
                {
                    if (item is TextObject)
                    {
                        if(item.Name == "txtTenLop")
                        {
                            TextObject textObject = (TextObject)item;
                            textObject.Text = "Tên lớp: " + txtTenLop.Text;
                        }    
                    }
                }
                crvBangDiemMonHoc.ReportSource = document;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
