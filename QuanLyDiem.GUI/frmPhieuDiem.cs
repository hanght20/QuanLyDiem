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
    public partial class frmPhieuDiem : Form
    {
        public frmPhieuDiem()
        {
            InitializeComponent();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            DiemBLL bllDiem = new DiemBLL();
            
            DataTable table = new DataTable();
            try
            {
                table = bllDiem.GetPhieuDiem(txtMaSV.Text);
                Report.PhieuDiem document = new Report.PhieuDiem();
                document.SetDataSource(table);
                foreach (ReportObject item in document.ReportDefinition.ReportObjects)
                {
                    if (item is TextObject)
                    {
                        if (item.Name == "txtMaSV")
                        {
                            TextObject textObject = (TextObject)item;
                            textObject.Text = "Mã SV: " + txtMaSV.Text;
                        }
                    }
                }
                crvPhieuDiem.ReportSource = document;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
