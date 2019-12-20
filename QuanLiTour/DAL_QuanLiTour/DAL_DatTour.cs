using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QuanLiTour;

namespace DAL_QuanLiTour
{
    public class DAL_DatTour
    {
        DAL_QuanLiTravelDataContext db = new DAL_QuanLiTravelDataContext();
        public List<DTO_TourDat> getTourDat()
        {
            var a = from td in db.TOURDATs
                    from l in db.LICHKHOIHANHs
                    from ds in db.DANHSACHNGUOIDIKEMs
                    from kh in db.KHACHHANGs
                    from ltt in db.LOAITHANHTOANs
                    from t in db.TOURs
                    where td.MALICH == l.MALICH &&
                            td.MADANHSACH == ds.MADANHSACH &&
                            td.MAKHACHHANG == kh.MAKHACHHANG &&
                            td.MALOAITT == ltt.MALOAITT &&
                            l.MATOUR == t.MATOUR
                    select new DTO_TourDat
                    {
                        MATOURDAT = td.MATOURDAT,
                        TENTOUR = t.TENTOUR,
                        MALICH = td.MALICH,
                        TENLICH = l.TENLICH,
                        MADANHSACH = td.MADANHSACH,
                        TENDANHSACH = ds.TENDANHSACH,
                        MAKHACHHANG = td.MAKHACHHANG,
                        TENKHACHHANG = kh.TENKHACHHANG,
                        MALOAITT = td.MALOAITT,
                        TENLOAITT = ltt.TENLOAITT,
                        NGAYDAT = System.DateTime.Parse(td.NGAYDAT.ToString()),
                        TRANGTHAI = td.TRANGTHAI,
                        TONGTIEN = float.Parse(td.TONGTIEN.ToString()),
                        DIEMDON = td.DIEMDON
                    };
            var kq = a.ToList().ConvertAll(t => new DTO_TourDat
            {
                MATOURDAT = t.MATOURDAT,
                TENTOUR = t.TENTOUR,
                MALICH = t.MALICH,
                TENLICH = t.TENLICH,
                MADANHSACH = t.MADANHSACH,
                TENDANHSACH = t.TENDANHSACH,
                MAKHACHHANG = t.MAKHACHHANG,
                TENKHACHHANG = t.TENKHACHHANG,
                MALOAITT = t.MALOAITT,
                TENLOAITT = t.TENLOAITT,
                NGAYDAT = System.DateTime.Parse(t.NGAYDAT.ToString()),
                TRANGTHAI = t.TRANGTHAI,
                TONGTIEN = float.Parse(t.TONGTIEN.ToString()),
                DIEMDON = t.DIEMDON
            });
            return kq.ToList<DTO_TourDat>();     
        }
        public string getMaTourDat()
        {
            string ma = "TD";
            var a = db.TOURDATs.Select(t => t).ToList<TOURDAT>();
            int i = a.Count;
            string Str = a[i - 1].MATOURDAT.ToString();
            int k = int.Parse(Str.Substring(2));
            string Str3 = (k + 1).ToString();
            if (int.Parse(Str3) < 10)
            {
                return ma + "000" + Str3;
            }
            else if (int.Parse(Str3) > 9)
            {
                return ma + "00" + Str3;
            }
            else if (int.Parse(Str3) > 99)
            {
                return ma + "0" + Str3;
            }
            else return ma + Str3;
        }
        public string ActionDatTour(string matour)
        {
            if (matour == null)
                return null;
            else
                return matour;
        }
        public bool addDatTour(TOURDAT a)
        {
                db.TOURDATs.InsertOnSubmit(a);
                db.SubmitChanges();
                return true;
            
        }
        public bool UpdateDatTour(TOURDAT a)
        {
            try
            {
                TOURDAT update = db.TOURDATs.Where(t => t.MATOURDAT.Equals(a.MATOURDAT)).SingleOrDefault();
                update.MALICH = a.MALICH;
                update.MADANHSACH = a.MADANHSACH;
                update.MAKHACHHANG = a.MAKHACHHANG;
                update.MALOAITT = a.MALOAITT;
                update.NGAYDAT = a.NGAYDAT;
                update.DIEMDON = a.DIEMDON;
                update.TRANGTHAI = a.TRANGTHAI;
                update.TONGTIEN = a.TONGTIEN;
                db.SubmitChanges();
                return true;
            }
            catch { return false; }
        }
        public bool deleteDatTour(TOURDAT a)
        {
            try
            {
                TOURDAT delete = db.TOURDATs.Where(t => t.MATOURDAT.Equals(a.MATOURDAT)).SingleOrDefault();
                db.TOURDATs.DeleteOnSubmit(delete);
                db.SubmitChanges();
                return true;
            }
            catch { return false; }
        }
        public bool deleteTD(string a)
        {
            try
            {
                TOURDAT delete = db.TOURDATs.Where(t => t.MATOURDAT.Equals(a)).SingleOrDefault();
                db.TOURDATs.DeleteOnSubmit(delete);
                db.SubmitChanges();
                return true;
            }
            catch { return false; }
        }
    }
}
