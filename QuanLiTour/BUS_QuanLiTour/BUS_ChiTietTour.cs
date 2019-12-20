using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QuanLiTour;
using DTO_QuanLiTour;

namespace BUS_QuanLiTour
{
    public class BUS_ChiTietTour
    {
        DAL_ChiTietTour dal = new DAL_ChiTietTour();
        public List<DTO_ChiTietTour> getChiTietThamQuan(string matour)
        {
            return dal.getChiTietThamQuan(matour);
        }
        public bool addCTTour(CHITIETTHAMQUAN a)
        {
            return dal.addCTTour(a);
        }
        public bool updateCTTour(CHITIETTHAMQUAN a)
        {
            return dal.updateCTTour(a);
        }
        public bool deleteCTTour(CHITIETTHAMQUAN a)
        {
            return dal.deleteCTTour(a);
        }
        public List<QUOCGIA> getQuocGia()
        {
            return dal.getQuocGia();
        }
        public bool getLoaiTour(string matour)
        {
            return dal.getLoaiTour(matour);
        }
        public List<TINH> getTinh()
        {
            return dal.getTinh();
        }
        public List<DIADIEMDULICH> getListDiaDiem(string matinh)
        {
            return dal.getListDiaDiem(matinh);
        }
        public List<DIADIEMDULICH> getDiaDiem()
        {
            return dal.getDiaDiem();
        }
    }

}
