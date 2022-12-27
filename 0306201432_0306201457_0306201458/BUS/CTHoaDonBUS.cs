using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class CTHoaDonBUS
    {
        CTHoaDonDAO cthoadonDAO = new CTHoaDonDAO();
        public List<CTHoaDonDTO> LayDSCTHD()
        {
            return cthoadonDAO.LayDSCTHD();
        }
        public bool ThemCTHD(CTHoaDonDTO cthd)
        {
            return cthoadonDAO.ThemCTHD(cthd);
        }
        public List<CTHoaDonDTO> LayDSCTHD_HD(string HD)
        {
            return cthoadonDAO.LayDSCTHD_HD(HD);
        }
    }
}
