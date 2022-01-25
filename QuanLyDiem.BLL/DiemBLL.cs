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
    public class DiemBLL
    {
        DiemDAL dalDiem;
        public List<Diem> GetAll()
        {
            dalDiem = new DiemDAL();
            try
            {
                return dalDiem.GetAll();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool Insert(Diem diem)
        {
            dalDiem = new DiemDAL();
            try
            {
                return dalDiem.Insert(diem);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool Update(Diem diem)
        {
            dalDiem = new DiemDAL();
            try
            {
                return dalDiem.Update(diem);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool Delete(Diem diem)
        {
            dalDiem = new DiemDAL();
            try
            {
                return dalDiem.Delete(diem);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable GetPhieuDiem(string masv)
        {
            dalDiem = new DiemDAL();
            try
            {
                return dalDiem.GetPhieuDiem(masv);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message); ;
            }
        }
        public DataTable GetPhieuDiemThi(string tenlop, string tenmonhoc, int lan)
        {
            dalDiem = new DiemDAL();
            try
            {
                return dalDiem.GetPhieuDiemThi(tenlop, tenmonhoc, lan);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message); ;
            }
        }
        public DataTable GetBangDiemMonHoc(string tenlop)
        {
            dalDiem = new DiemDAL();
            try
            {
                return dalDiem.GetBangDiemMonHoc(tenlop);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message); ;
            }
        }
        public DataTable GetBangDiemTongKet(string tenlop)
        {
            dalDiem = new DiemDAL();
            try
            {
                return dalDiem.GetBangDiemTongKet(tenlop);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message); ;
            }
        }
    }
}
