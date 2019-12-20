using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QuanLiTour
{
    public class DAL_LichKhoiHanh
    {
        DAL_QuanLiTravelDataContext db = new DAL_QuanLiTravelDataContext();
        public List<LICHKHOIHANH> getLichKhoiHanh()
        {
            var a = db.LICHKHOIHANHs.Select(t => t).ToList<LICHKHOIHANH>();
            return a.ToList<LICHKHOIHANH>();
        }
        public List<LICHKHOIHANH> getLichKhoiHanhTour(string matour)
        {
            return db.LICHKHOIHANHs.Where(t => t.MATOUR.Equals(matour)).ToList<LICHKHOIHANH>();
        }
        public string getMaTour(string malich)
        {
            var a = db.LICHKHOIHANHs.Where(t => t.MALICH.Equals(malich)).ToList<LICHKHOIHANH>();
            string ma = a[0].MATOUR.ToString();
            return ma;
        }
        public string getMaLich()
        {
            string ma = "ML";
            var a = db.LICHKHOIHANHs.Select(t => t).ToList<LICHKHOIHANH>();
            int i = a.Count;
            string Str = a[i - 1].MALICH.ToString();
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
        public bool addLichKhoihanh(LICHKHOIHANH a)
        {
            try
            {
                db.LICHKHOIHANHs.InsertOnSubmit(a);
                db.SubmitChanges();
                return true;
            }
            catch 
            { 
                return false; 
            }
        }
        public bool editLichKhoihanh(LICHKHOIHANH a)
        {
            try
            {
                LICHKHOIHANH b = db.LICHKHOIHANHs.Where(t=>t.MALICH.Equals(a.MALICH)).SingleOrDefault();
                b.MATOUR = a.MATOUR;
                b.TENLICH = a.TENLICH;
                b.SOCHOTRONG = a.SOCHOTRONG;
                b.LICHKHOIHANH1 = a.LICHKHOIHANH1;
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool deleteLichKhoiHanh(string maL)
        {
            try
            {
                LICHKHOIHANH a = db.LICHKHOIHANHs.Where(t => t.MALICH.Equals(maL)).SingleOrDefault();
                db.LICHKHOIHANHs.DeleteOnSubmit(a);
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
