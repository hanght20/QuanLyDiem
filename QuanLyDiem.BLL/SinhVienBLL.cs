using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDiem.DAL;
using QuanLyDiem.DTO;

namespace QuanLyDiem.BLL
{
    public class SinhVienBLL
    {
        SinhVienDAL dalSinhVien;
        public List<SinhVien> GetAll()
        {
            dalSinhVien = new SinhVienDAL();
            try
            {
                return dalSinhVien.GetAll();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool Insert(SinhVien sv)
        {
            dalSinhVien = new SinhVienDAL();
            try
            {
                return dalSinhVien.Insert(sv);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        

        public DataTable GetDanhSachSinhVienTheoLop(string malop)
        {
            dalSinhVien = new SinhVienDAL();
            try
            {
                return dalSinhVien.GetDanhSachSinhVienTheoLop(malop);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message); ;
            }
        }

        public bool Update(SinhVien sv)
        {
            dalSinhVien = new SinhVienDAL();
            try
            {
                return dalSinhVien.Update(sv);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool Delete(SinhVien sv)
        {
            dalSinhVien = new SinhVienDAL();
            try
            {
                return dalSinhVien.Delete(sv);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
