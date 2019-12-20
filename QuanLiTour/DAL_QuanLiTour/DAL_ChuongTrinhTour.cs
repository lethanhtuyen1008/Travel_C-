using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QuanLiTour;
using System.Data;

namespace DAL_QuanLiTour
{
    public class DAL_ChuongTrinhTour
    {
        DAL_QuanLiTravelDataContext db = new DAL_QuanLiTravelDataContext();
        public List<DTO_ChuongTrinhTour> getListChuongTrinhTour(string maTour)
        {
            var ds = from ct in db.CHUONGTRINHTOURs
                     from to in db.TOURs
                     from ks in db.KHACHSANs
                     where ct.MATOUR == maTour && to.MATOUR == ct.MATOUR && ks.MAKHACHSAN== ct.MAKHACHSAN
                     select new DTO_ChuongTrinhTour
                     {
                         MACHUONGTRINH = ct.MACHUONGTRINH,
                         MATOUR = ct.MATOUR,
                         TENTOUR = to.TENTOUR,
                         MAKHACHSAN = ct.MAKHACHSAN,
                         TENKHACHSAN = ks.TENKHACHSAN,
                         TENCHUONGTRINH = ct.TENCHUONGTRINH,
                         NGAY = ct.NGAY,
                         GHICHU = ct.GHICHU,
                     };
            var kq = ds.ToList().ConvertAll(t => new DTO_ChuongTrinhTour
            {
                MACHUONGTRINH = t.MACHUONGTRINH,
                MATOUR = t.MATOUR,
                TENTOUR = t.TENTOUR,
                MAKHACHSAN = t.MAKHACHSAN,
                TENKHACHSAN = t.TENKHACHSAN,
                TENCHUONGTRINH = t.TENCHUONGTRINH,
                NGAY = t.NGAY,
                GHICHU = t.GHICHU,
            });
            return kq.ToList<DTO_ChuongTrinhTour>();
        }
        public List<DTO_ChuongTrinhTour> getAllChuongTrinhTour()
        {
            var ds = from ct in db.CHUONGTRINHTOURs
                     from to in db.TOURs
                     from ks in db.KHACHSANs
                     where to.MATOUR == ct.MATOUR && ks.MAKHACHSAN == ct.MAKHACHSAN
                     select new DTO_ChuongTrinhTour
                     {
                         MACHUONGTRINH = ct.MACHUONGTRINH,
                         MATOUR = ct.MATOUR,
                         TENTOUR = to.TENTOUR,
                         MAKHACHSAN = ct.MAKHACHSAN,
                         TENKHACHSAN = ks.TENKHACHSAN,
                         TENCHUONGTRINH = ct.TENCHUONGTRINH,
                         NGAY = ct.NGAY,
                         GHICHU = ct.GHICHU,
                     };
            var kq = ds.ToList().ConvertAll(t => new DTO_ChuongTrinhTour
            {
                MACHUONGTRINH = t.MACHUONGTRINH,
                MATOUR = t.MATOUR,
                TENTOUR = t.TENTOUR,
                MAKHACHSAN = t.MAKHACHSAN,
                TENKHACHSAN = t.TENKHACHSAN,
                TENCHUONGTRINH = t.TENCHUONGTRINH,
                NGAY = t.NGAY,
                GHICHU = t.GHICHU,
            });
            return kq.ToList<DTO_ChuongTrinhTour>();
        }
        public string getMaChuongTrinh()
        {
            string ma = "CT";
            var a = db.CHUONGTRINHTOURs.Select(t => t).ToList<CHUONGTRINHTOUR>();
            int i = a.Count;
            string Str = a[i - 1].MACHUONGTRINH.ToString();
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
        public bool addCTTour(CHUONGTRINHTOUR a)
        {
            try
            {
                CHUONGTRINHTOUR add = new CHUONGTRINHTOUR();
                add.MACHUONGTRINH = a.MACHUONGTRINH;
                add.MATOUR = a.MATOUR;
                add.MAKHACHSAN = a.MAKHACHSAN;
                add.TENCHUONGTRINH = a.TENCHUONGTRINH;
                add.NGAY = a.NGAY;
                add.GHICHU = a.GHICHU;
                db.CHUONGTRINHTOURs.InsertOnSubmit(add);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool deleteCTTour(string mact)
        {
            try
            {
                CHUONGTRINHTOUR delete = db.CHUONGTRINHTOURs.Where(t => t.MACHUONGTRINH.Equals(mact)).SingleOrDefault();
                db.CHUONGTRINHTOURs.DeleteOnSubmit(delete);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool editCTTour(CHUONGTRINHTOUR a)
        {
            try
            {
                CHUONGTRINHTOUR edit = db.CHUONGTRINHTOURs.Where(t=>t.MACHUONGTRINH.Equals(a.MACHUONGTRINH)).SingleOrDefault();
                edit.MACHUONGTRINH = a.MACHUONGTRINH;
                edit.TENCHUONGTRINH = a.TENCHUONGTRINH;
                edit.MAKHACHSAN = a.MAKHACHSAN;
                edit.MATOUR = a.MATOUR;
                edit.NGAY = a.NGAY;
                edit.GHICHU = a.GHICHU;
                db.SubmitChanges();
                return true;
            }
            catch {
                return false;
            }
        }
    }
}