using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QuanLiTour;
using DTO_QuanLiTour;
namespace BUS_QuanLiTour
{
    public class BUS_GiaTour
    {
        DAL_GiaTour dal = new DAL_GiaTour();
        public List<GIAVE> getListGia()
        {
            return dal.getGiaTour();
        }
        public List<CHITIETGIAVE> getChiTietGia(string magiave)
        {
            return dal.getChiTietGia(magiave);
        }
        public string getMaGiave()
        {
            return dal.getMaGiave();
        }
        public bool addGiaVe(GIAVE a)
        {
            return dal.addGiaVe(a);
        }
    }
}
