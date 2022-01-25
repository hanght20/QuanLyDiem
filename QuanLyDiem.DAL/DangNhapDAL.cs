using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyDiem.DTO;

namespace QuanLyDiem.DAL
{
    public class DangNhapDAL
    {
        DBLib db = new DBLib();
        public List<DangNhap> GetAll()
        {
            throw new NotImplementedException();
        }
        public bool Insert(DangNhap dangnhap)
        {
            throw new NotImplementedException();
        }
        public bool Update(DangNhap dangnhap)
        {
            throw new NotImplementedException();
        }
        public bool Delete(DangNhap dangnhap)
        {
            throw new NotImplementedException();
        }
        public bool DangNhap(string username, string password)
        {
            bool check = false;
            db = new DBLib();
            DataTable table = new DataTable();
            string[] arrPara = new string[] { "@username", "@password" };
            object[] arrValue = new object[] { username, password };
            SqlDbType[] arrSqlDbType = new SqlDbType[2] { SqlDbType.VarChar, SqlDbType.NVarChar};
            try
            {
                table = db.FillDataTable("sp_DangNhap", CommandType.StoredProcedure, arrPara, arrValue, arrSqlDbType);
                if (table.Rows.Count > 0)
                {
                    check = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return check;
        }
    }
}
