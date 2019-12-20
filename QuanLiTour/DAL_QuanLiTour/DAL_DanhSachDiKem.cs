using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QuanLiTour
{
    public class DAL_DanhSachDiKem
    {
        DAL_QuanLiTravelDataContext db = new DAL_QuanLiTravelDataContext();
        public List<DANHSACHNGUOIDIKEM> getListDanhSachDK()
        {
            var a = db.DANHSACHNGUOIDIKEMs.Select(t => t).ToList<DANHSACHNGUOIDIKEM>();
            return a.ToList<DANHSACHNGUOIDIKEM>();
        }
        public bool addDSDiKem(DANHSACHNGUOIDIKEM a)
        {
            try
            {
                db.DANHSACHNGUOIDIKEMs.InsertOnSubmit(a);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool editDSDiKem(DANHSACHNGUOIDIKEM a)
        {
            try
            {
                DANHSACHNGUOIDIKEM e = db.DANHSACHNGUOIDIKEMs.Where(t => t.MADANHSACH.Equals(a.MADANHSACH)).SingleOrDefault();
                e.TENDANHSACH = a.TENDANHSACH;
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool deleteDSDiKem(string a)
        {
            try
            {
                DANHSACHNGUOIDIKEM de = db.DANHSACHNGUOIDIKEMs.Where(t => t.MADANHSACH.Equals(a)).SingleOrDefault();
                db.DANHSACHNGUOIDIKEMs.DeleteOnSubmit(de);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public string getMaDS()
        {
            string ma = "DS";
            var a = db.DANHSACHNGUOIDIKEMs.Select(t => t).ToList<DANHSACHNGUOIDIKEM>();
            int i = a.Count;
            string Str = a[i - 1].MADANHSACH.ToString();
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
    }
}
