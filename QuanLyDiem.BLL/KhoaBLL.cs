using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDiem.DAL;
using QuanLyDiem.DTO;


namespace QuanLyDiem.BLL
{
    public class KhoaBLL
    {
        KhoaDAL dalKhoa;
        public List<Khoa> GetAll()
        {
            dalKhoa = new KhoaDAL();
            try
            {
                return dalKhoa.GetAll();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool Insert(Khoa khoa)
        {
            dalKhoa = new KhoaDAL();
            try
            {
                return dalKhoa.Insert(khoa);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        
        public bool Update(Khoa khoa)
        {
            dalKhoa = new KhoaDAL();
            try
            {
                return dalKhoa.Update(khoa);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool Delete(Khoa khoa)
        {
            dalKhoa = new KhoaDAL();
            try
            {
                return dalKhoa.Delete(khoa);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
