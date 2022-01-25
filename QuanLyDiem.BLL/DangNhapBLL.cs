using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDiem.DAL;
using QuanLyDiem.DTO;

namespace QuanLyDiem.BLL
{
    public class DangNhapBLL
    {
        DangNhapDAL dalDangNhap = new DangNhapDAL();
        public List<DangNhap> GetAll()
        {
            dalDangNhap = new DangNhapDAL();
            try
            {
                return dalDangNhap.GetAll();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool Insert(DangNhap dangnhap)
        {
            dalDangNhap = new DangNhapDAL();
            try
            {
                return dalDangNhap.Insert(dangnhap);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool Update(DangNhap dangnhap)
        {
            dalDangNhap = new DangNhapDAL();
            try
            {
                return dalDangNhap.Update(dangnhap);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool DangNhap(string username, string password,string v)
        {
            dalDangNhap = new DangNhapDAL();
            try
            {
                return dalDangNhap.DangNhap(username, password);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
