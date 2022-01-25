using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDiem.DTO;
using System.Data;

namespace QuanLyDiem.DAL
{
    public class LopDAL
    {
        DBLib db = new DBLib();
     
        public List<Lop> GetAll()
        {
            db = new DBLib();
            List<Lop> list = new List<Lop>();
            DataTable table = new DataTable();
            try
            {
                table = db.FillDataTable("sp_SelectLop", CommandType.StoredProcedure);
                foreach (DataRow item in table.Rows)
                {
                    
                    Lop lop = new Lop();
                    lop.MaLop = item[0].ToString();
                    lop.TenLop = item[1].ToString();
                    lop.MaKh = item[2].ToString();
                    list.Add(lop);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return list;
        }
        public bool Insert(Lop lop)
        {
            bool check;
            db = new DBLib();
            db.AddParameter("@MaLop", lop.MaLop, ParameterDirection.Input);
            db.AddParameter("@TenLop", lop.TenLop, ParameterDirection.Input);
            db.AddParameter("@MaKh", lop.MaKh, ParameterDirection.Input);
            try
            {
                check = db.ExecuteNonQuery("sp_InsertLop", CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return check;
        }
        public bool Update(Lop lop)
        {
            bool check;
            db = new DBLib();
            db.AddParameter("@MaLop", lop.MaLop);
            db.AddParameter("@TenLop", lop.TenLop);
            db.AddParameter("@MaKh", lop.MaKh);
            try
            {
                check = db.ExecuteNonQuery("sp_UpdateLop", CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return check;
        }
        public bool Delete(Lop lop)
        {
            bool check;
            db = new DBLib();
            db.AddParameter("@MaLop", lop.MaLop);
            db.AddParameter("@TenLop", lop.TenLop);
            db.AddParameter("@MaKh", lop.MaKh);
            try
            {
                check = db.ExecuteNonQuery("sp_DeleteLop", CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return check;
        }
    }
}
