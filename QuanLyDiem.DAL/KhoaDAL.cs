using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyDiem.DTO;

namespace QuanLyDiem.DAL
{
    public class KhoaDAL
    {
        DBLib db = new DBLib();
        public List<Khoa> GetAll()
        {
            db = new DBLib();
            List<Khoa> listKhoa = new List<Khoa>();
            DataTable table = new DataTable();
            try
            {
                table = db.FillDataTable("sp_SelectKhoa", CommandType.StoredProcedure);
                foreach (DataRow item in table.Rows)
                {
                    Khoa khoa = new Khoa();
                    khoa.MaKh = item[0].ToString();
                    khoa.TenKh = item[1].ToString();
                    listKhoa.Add(khoa);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return listKhoa;
        }
        public bool Insert(Khoa khoa)
        {
            bool check;
            db = new DBLib();
            db.AddParameter("@MaKh", khoa.MaKh, ParameterDirection.Input);
            db.AddParameter("@TenKh", khoa.TenKh, ParameterDirection.Input);
            try
            {
                check = db.ExecuteNonQuery("sp_InsertKhoa", CommandType.StoredProcedure);
               
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return check;
        }
        public bool Update(Khoa khoa)
        {
            bool check;
            db = new DBLib();
            db.AddParameter("@MaKh", khoa.MaKh);
            db.AddParameter("@TenKh", khoa.TenKh);
            try
            {
                check = db.ExecuteNonQuery("sp_UpdateKhoa", CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return check;
        }
        public bool Delete(Khoa khoa)
        {
            bool check;
            db = new DBLib();
            db.AddParameter("@MaKh", khoa.MaKh);
            db.AddParameter("@TenKh", khoa.TenKh);
            try
            {
                check = db.ExecuteNonQuery("sp_DeleteKhoa", CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return check;
        }
    }
}
