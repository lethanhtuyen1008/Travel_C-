using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QuanLiTour;
using DAL_QuanLiTour;
using System.Data;
namespace BUS_QuanLiTour
{

    public class BUS_ChuongTrinhTour
    {
        DAL_ChuongTrinhTour dalCTTour = new DAL_ChuongTrinhTour();

        public List<DTO_ChuongTrinhTour> getListChuongTrinhTour(string ma)
        {
            return dalCTTour.getListChuongTrinhTour(ma);
        }
        public bool addCTTour(CHUONGTRINHTOUR a)
        {
            return dalCTTour.addCTTour(a);
        }
        public List<DTO_ChuongTrinhTour> getAllChuongTrinhTour()
        {
            return dalCTTour.getAllChuongTrinhTour();
        }
        public bool editCTTour(CHUONGTRINHTOUR a)
        {
            return dalCTTour.editCTTour(a);
        }
        public bool deleteCTTour(string a)
        {
            return dalCTTour.deleteCTTour(a);
        }
        public string getMaChuongTrinh()
        {
            return dalCTTour.getMaChuongTrinh();
        }
    }
}
