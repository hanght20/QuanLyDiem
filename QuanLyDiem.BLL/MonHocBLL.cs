using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDiem.DAL;
using QuanLyDiem.DTO;

namespace QuanLyDiem.BLL
{
    public class MonHocBLL
    {
        MonHocDAL dalMonHoc;
        public List<MonHoc> GetAll()
        {
            dalMonHoc = new MonHocDAL();
            try
            {
                return dalMonHoc.GetAll();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool Insert(MonHoc monhoc)
        {
            dalMonHoc = new MonHocDAL();
            try
            {
                return dalMonHoc.Insert(monhoc);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<MonHoc> GetALL()
        {
            throw new NotImplementedException();
        }

        public bool Update(MonHoc monhoc)
        {
            dalMonHoc = new MonHocDAL();
            try
            {
                return dalMonHoc.Update(monhoc);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool Delete(MonHoc monhoc)
        {
            dalMonHoc = new MonHocDAL();
            try
            {
                return dalMonHoc.Delete(monhoc);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
