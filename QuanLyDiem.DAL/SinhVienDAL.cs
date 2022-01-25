using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDiem.DTO;
using System.Data;

namespace QuanLyDiem.DAL
{
    public class SinhVienDAL
    {
        DBLib db = new DBLib();
        public List<SinhVien> GetAll()
        {
            db = new DBLib();
            List<SinhVien> list = new List<SinhVien>();
            DataTable table = new DataTable();
            try
            {
                table = db.FillDataTable("sp_SelectSinhVien", CommandType.StoredProcedure);
                foreach (DataRow item in table.Rows)
                {
                    SinhVien sv = new SinhVien();
                    sv.MaSV = item[0].ToString();
                    sv.Ho = item[1].ToString();
                    sv.Ten = item[2].ToString();
                    sv.MaLop = item[3].ToString();
                    sv.Phai = (bool)item[4];
                    sv.NgaySinh = (DateTime)item[5];
                    sv.NoiSinh = item[6].ToString();
                    sv.DiaChi = item[7].ToString();
                    sv.NghiHoc = (bool)item[8];
                    list.Add(sv);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return list;
        }
        public bool Insert(SinhVien sv)
        {
            bool check;
            db = new DBLib();
            db.AddParameter("@MaSV", sv.MaSV, ParameterDirection.Input);
            db.AddParameter("@Ho", sv.Ho, ParameterDirection.Input);
            db.AddParameter("@Ten", sv.Ten, ParameterDirection.Input);
            db.AddParameter("@MaLop", sv.MaLop, ParameterDirection.Input);
            db.AddParameter("@Phai", sv.Phai, ParameterDirection.Input);
            db.AddParameter("@NgaySinh", sv.NgaySinh, ParameterDirection.Input);
            db.AddParameter("@NoiSinh", sv.NoiSinh, ParameterDirection.Input);
            db.AddParameter("@DiaChi", sv.DiaChi, ParameterDirection.Input);
            db.AddParameter("@NghiHoc", sv.NghiHoc, ParameterDirection.Input);
            try
            {
                check = db.ExecuteNonQuery("sp_InsertSinhVien", CommandType.StoredProcedure);
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return check;
        }
        public bool Update(SinhVien sv)
        {
            bool check;
            db = new DBLib();
            db.AddParameter("@MaSV", sv.MaSV);
            db.AddParameter("@Ho", sv.Ho);
            db.AddParameter("@Ten", sv.Ten);
            db.AddParameter("@MaLop", sv.MaLop);
            db.AddParameter("@Phai", sv.Phai);
            db.AddParameter("@NgaySinh", sv.NgaySinh);
            db.AddParameter("@NoiSinh", sv.NoiSinh);
            db.AddParameter("@DiaChi", sv.DiaChi);
            db.AddParameter("@NghiHoc", sv.NghiHoc);
            try
            {
                check = db.ExecuteNonQuery("sp_UpdateSinhVien", CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return check;
        }
        public bool Delete(SinhVien sv)
        {
            bool check;
            db = new DBLib();
            db.AddParameter("@MaSV", sv.MaSV);
            db.AddParameter("@Ho", sv.Ho);
            db.AddParameter("@Ten", sv.Ten);
            db.AddParameter("@MaLop", sv.MaLop);
            db.AddParameter("@Phai", sv.Phai);
            db.AddParameter("@NgaySinh", sv.NgaySinh);
            db.AddParameter("@NoiSinh", sv.NoiSinh);
            db.AddParameter("@DiaChi", sv.DiaChi);
            db.AddParameter("@NghiHoc", sv.NghiHoc);
            try
            {
                check = db.ExecuteNonQuery("sp_DeleteSinhVien", CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return check;
        }
        public DataTable GetDanhSachSinhVienTheoLop(string malop)
        {
            DataTable table = new DataTable();
            db = new DBLib();
            string[] arrPara = new string[1] { "@MaLop" };
            object[] arrValue = new object[1] { malop };
            SqlDbType[] arrSqlDbType = new SqlDbType[1] { SqlDbType.VarChar };

            try
            {
                
                table = db.FillDataTable("sp_DanhSachSinhVienTheoLop", CommandType.StoredProcedure, arrPara, arrValue, arrSqlDbType);
                
            }
            catch (Exception ex) 
            {
                throw new Exception(ex.Message);
            }
            return table;
        }
    }
}
