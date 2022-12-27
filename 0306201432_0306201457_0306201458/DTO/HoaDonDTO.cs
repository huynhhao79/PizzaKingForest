using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDonDTO
    {
        public string MaHD { get; set; }
        public string MaNV {get;set;}
        
        public DateTime NgayLapHD {get;set;}
        public decimal Tong { get; set; }

        public int TrangThai { get; set; }
    }
}
