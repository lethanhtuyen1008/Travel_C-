using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QuanLiTour
{
    public class DAL_ChiTietChuongTrinh
    {
        DAL_QuanLiTravelDataContext db = new DAL_QuanLiTravelDataContext();
        public List<CHITIETCHUONGTRINH> getListCTChuongTrinh(string mact)
        {
            var a = db.CHITIETCHUONGTRINHs.Where(t => t.MACHUONGTRINH.Equals(mact)).ToList<CHITIETCHUONGTRINH>();
            return a;
        }
        public List<CHITIETCHUONGTRINH> getAllCTChuongTrinh()
        {
            var a = db.CHITIETCHUONGTRINHs.Select(t => t).ToList<CHITIETCHUONGTRINH>();
            return a;
        }
        public bool addCTChuongTrinh(CHITIETCHUONGTRINH a)
        {
            try
            {
                db.CHITIETCHUONGTRINHs.InsertOnSubmit(a);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool editCTChuongTrinh(CHITIETCHUONGTRINH a)
        {
            try
            {
                CHITIETCHUONGTRINH e = db.CHITIETCHUONGTRINHs.Where(t => t.MACHUONGTRINH.Equals(a.MACHUONGTRINH) && t.MADIADIEM.Equals(a.MADIADIEM)).SingleOrDefault();
                e.GHICHU = a.GHICHU;
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool deleteCTChuongTrinh(CHITIETCHUONGTRINH a)
        {
            try
            {
                CHITIETCHUONGTRINH d = db.CHITIETCHUONGTRINHs.Where(t => t.MACHUONGTRINH.Equals(a.MACHUONGTRINH) && t.MADIADIEM.Equals(a.MADIADIEM)).SingleOrDefault();
                db.CHITIETCHUONGTRINHs.DeleteOnSubmit(d);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
