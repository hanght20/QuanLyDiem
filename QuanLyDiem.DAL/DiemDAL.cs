using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyDiem.DTO;

namespace QuanLyDiem.DAL
{
    public class DiemDAL
    {
        DBLib db = new DBLib();
        public List<Diem> GetAll()
        {
            db = new DBLib();
            List<Diem> list = new List<Diem>();
            DataTable table = new DataTable();
            try
            {
                table = db.FillDataTable("sp_SelectDiem", CommandType.StoredProcedure);
                foreach (DataRow item in table.Rows)
                {
                    Diem diem = new Diem();
                    diem.MaSV = item[0].ToString();
                    diem.MaMH = item[1].ToString();
                    diem.Lan = (int)item[2];
                    diem.Diemthi = (float)item[3];
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return list;
        }
        public bool Insert(Diem diem)
        {
            bool check;
            db = new DBLib();
            db.AddParameter("@MaSV", diem.MaSV, ParameterDirection.Input);
            db.AddParameter("@MaMH", diem.MaMH, ParameterDirection.Input);
            db.AddParameter("@Lan", diem.Lan, ParameterDirection.Input);
            db.AddParameter("@Diemthi", diem.Diemthi, ParameterDirection.Input);
            try
            {
                check = db.ExecuteNonQuery("sp_InsertDiem", CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return check;
        }
        public bool Update(Diem diem)
        {
            bool check;
            db = new DBLib();
            db.AddParameter("@MaSV", diem.MaSV);
            db.AddParameter("@MaMH", diem.MaMH);
            db.AddParameter("@Lan", diem.Lan);
            db.AddParameter("@Diemthi", diem.Diemthi);
            try
            {
                check = db.ExecuteNonQuery("sp_UpdateDiem", CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return check;
        }
        public bool Delete(Diem diem)
        {
            bool check;
            db = new DBLib();
            db.AddParameter("@MaSV", diem.MaSV);
            db.AddParameter("@MaMH", diem.MaMH);
            db.AddParameter("@Lan", diem.Lan);
            db.AddParameter("@Diemthi", diem.Diemthi);
            try
            {
                check = db.ExecuteNonQuery("sp_DeleteDiem", CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return check;
        }
        public DataTable GetPhieuDiem(string masv)
        {
            DataTable table = new DataTable();
            db = new DBLib();
            string[] arrPara = new string[1] { "@MaSV" };
            object[] arrValue = new object[1] { masv};
            SqlDbType[] arrSqlDbType = new SqlDbType[1] { SqlDbType.VarChar };
            try
            {
                table = db.FillDataTable("sp_PhieuDiem", CommandType.StoredProcedure, arrPara, arrValue, arrSqlDbType);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return table;
        }
        public DataTable GetPhieuDiemThi(string tenlop, string tenmonhoc,int lan)
        {
            DataTable table = new DataTable();
            db = new DBLib();
            string[] arrPara = new string[3] { "@TenLop","@TenMH","@Lan" };
            object[] arrValue = new object[3] { tenlop, tenmonhoc,lan };
            SqlDbType[] arrSqlDbType = new SqlDbType[1] { SqlDbType.VarChar };
            try
            {
                table = db.FillDataTable("sp_PhieuDiemThi", CommandType.StoredProcedure, arrPara, arrValue, arrSqlDbType);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return table;
        }
        public DataTable GetBangDiemMonHoc(string tenlop)
        {
            DataTable table = new DataTable();
            db = new DBLib();
            string[] arrPara = new string[1] { "@TenLop" };
            object[] arrValue = new object[1] { tenlop };
            SqlDbType[] arrSqlDbType = new SqlDbType[1] { SqlDbType.VarChar };
            try
            {
                table = db.FillDataTable("sp_BangDiemMonHoc", CommandType.StoredProcedure, arrPara, arrValue, arrSqlDbType);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return table;
        }
        public DataTable GetBangDiemTongKet(string tenlop)
        {
            DataTable table = new DataTable();
            db = new DBLib();
            string[] arrPara = new string[1] { "@TenLop" };
            object[] arrValue = new object[1] { tenlop };
            SqlDbType[] arrSqlDbType = new SqlDbType[1] { SqlDbType.VarChar };
            try
            {
                table = db.FillDataTable("sp_BangDiemTongKet", CommandType.StoredProcedure, arrPara, arrValue, arrSqlDbType);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return table;
        }
    }
}
