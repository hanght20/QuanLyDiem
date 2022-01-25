using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyDiem.DTO;

namespace QuanLyDiem.DAL
{
    public class MonHocDAL
    {
        DBLib db = new DBLib();
        public List<MonHoc> GetAll()
        {
            db = new DBLib();
            List<MonHoc> list = new List<MonHoc>();
            DataTable table = new DataTable();
            try
            {
                table = db.FillDataTable("sp_SelectMonHoc", CommandType.StoredProcedure);
                foreach (DataRow item in table.Rows)
                {
                    MonHoc monhoc = new MonHoc();
                    monhoc.MaMH = item[0].ToString();
                    monhoc.TenMH = item[1].ToString();
                    list.Add(monhoc);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return list;
        }
        public bool Insert(MonHoc monhoc)
        {
            bool check;
            db = new DBLib();
            db.AddParameter("@MaMH", monhoc.MaMH, ParameterDirection.Input);
            db.AddParameter("@TenMH", monhoc.TenMH, ParameterDirection.Input);
            try
            {
                check = db.ExecuteNonQuery("sp_InsertMonHoc", CommandType.StoredProcedure);
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return check;
        }
        public bool Update(MonHoc monhoc)
        {
            bool check;
            db = new DBLib();
            db.AddParameter("@MaMH", monhoc.MaMH);
            db.AddParameter("@TenMH", monhoc.TenMH);
            try
            {
                check = db.ExecuteNonQuery("sp_UpdateMonHoc", CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return check;
        }
        public bool Delete(MonHoc monhoc)
        {
            bool check;
            db = new DBLib();
            db.AddParameter("@MaMH", monhoc.MaMH);
            db.AddParameter("@TenMH", monhoc.TenMH);
            try
            {
                check = db.ExecuteNonQuery("sp_DeleteMonHoc", CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return check;
        }
        public DataTable GetBangDiemMonHoc(string tenlop,string tenmonhoc,int lan)
        {
            db = new DBLib();
            DataTable table = new DataTable();
            try
            {
                string[] arrPara = new string[1] { "@Tenlop" };
                object[] arrValue = new object[1] { tenlop };

            }
            catch (Exception)
            {

                throw;
            }
            return table;
        }
        
    }
}
