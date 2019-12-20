using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL_QuanLiTour;
using DTO_QuanLiTour;
using System.Threading.Tasks;

namespace BUS_QuanLiTour
{
    public class BUS_ChiTietChuongTrinh
    {
        DAL_ChiTietChuongTrinh dal = new DAL_ChiTietChuongTrinh();
        public List<CHITIETCHUONGTRINH> getListChuongTrinh(string maC)
        {
            return dal.getListCTChuongTrinh(maC);
        }
        public List<CHITIETCHUONGTRINH> getAllCTChuongTrinh()
        {
            return dal.getAllCTChuongTrinh();
        }
        public bool addCTChuongTrinh(CHITIETCHUONGTRINH a)
        {
            return dal.addCTChuongTrinh(a);
        }
        public bool editCTChuongTrinh(CHITIETCHUONGTRINH a)
        {
            return dal.editCTChuongTrinh(a);
        }
        public bool deleteCTChuongTrinh(CHITIETCHUONGTRINH a)
        {
            return dal.deleteCTChuongTrinh(a);
        }
    }
}
