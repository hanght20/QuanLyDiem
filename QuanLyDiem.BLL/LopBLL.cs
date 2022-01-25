using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDiem.DAL;
using QuanLyDiem.DTO;

namespace QuanLyDiem.BLL
{
    public class LopBLL
    {
        LopDAL dalLop;
        public List<Lop> GetAll()
        {
            dalLop = new LopDAL();
            try
            {
                return dalLop.GetAll();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool Insert(Lop lop)
        {
            dalLop = new LopDAL();
            try
            {
                return dalLop.Insert(lop);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool Update(Lop lop)
        {
            dalLop = new LopDAL();
            try
            {
                return dalLop.Update(lop);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool Delete(Lop lop)
        {
            dalLop = new LopDAL();
            try
            {
                return dalLop.Delete(lop);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
