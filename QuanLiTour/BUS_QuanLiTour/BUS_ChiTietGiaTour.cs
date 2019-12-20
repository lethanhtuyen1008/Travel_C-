using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QuanLiTour;
using DTO_QuanLiTour;

namespace BUS_QuanLiTour
{
    public class BUS_ChiTietGiaTour
    {
        DAL_ChiTietGiaVe dal = new DAL_ChiTietGiaVe();
        public List<DTO_ChiTietGiaTour> getListChiTietGia(string mag)
        {
            return dal.getListChiTietGia(mag);
        }
        public bool addCTGV(CHITIETGIAVE a)
        {
            return dal.addCTGV(a);
        }
    }
}
