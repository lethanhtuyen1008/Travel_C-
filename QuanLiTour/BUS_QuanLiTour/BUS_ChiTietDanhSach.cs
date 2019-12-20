using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QuanLiTour;
namespace BUS_QuanLiTour
{
    public class BUS_ChiTietDanhSach
    {
        DAL_ChiTietDanhSach dal = new DAL_ChiTietDanhSach();
        public List<CHITIETDIKEM> getListDiKem(string ma)
        {
            return dal.getListCTDanhSach(ma);
        }
        public string getMaCTDS()
        {
            return dal.getMaChiTietDS();
        }
        public bool addCTDS(CHITIETDIKEM a)
        {
            return dal.addCTDanhSach(a);
        }
        public bool editCTDS(CHITIETDIKEM a)
        {
            return dal.editCTDanhSach(a);
        }
        public bool deleteCTDS(CHITIETDIKEM a)
        {
            return dal.deleteCTDanhSach(a);
        }

    }
}
