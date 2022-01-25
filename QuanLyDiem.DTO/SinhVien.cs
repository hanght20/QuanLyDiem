using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiem.DTO
{
    public class SinhVien
    {
        public string MaSV { get; set; }
        public string Ho { get; set; }
        public string Ten { get; set; }
        public string MaLop { get; set; }
        public bool Phai { get; set; }
        public DateTime NgaySinh { get; set; }
        public string NoiSinh { get; set; }
        public string DiaChi { get; set; }
        public bool NghiHoc { get; set; }

    }
}
