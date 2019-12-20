using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QuanLiTour
{
    public class DAL_ChiTietDanhSach
    {
        DAL_QuanLiTravelDataContext db = new DAL_QuanLiTravelDataContext();
        public List<CHITIETDIKEM> getListCTDanhSach(string mads)
        {
            var a  = db.CHITIETDIKEMs.Where(t=>t.MADANHSACH.Equals(mads)).ToList<CHITIETDIKEM>();
            return a.ToList<CHITIETDIKEM>();
        }
        public string getMaChiTietDS()
        {
            string ma = "CT";
            var a = db.CHITIETDIKEMs.Select(t => t).ToList<CHITIETDIKEM>();
            int i = a.Count;
            if (i == 0) return "CT0001";
            string Str = a[i - 1].MACHITIET.ToString();
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
        public bool addCTDanhSach(CHITIETDIKEM a)
        {
            try
            {
                db.CHITIETDIKEMs.InsertOnSubmit(a);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool editCTDanhSach(CHITIETDIKEM a)
        {
            try
            {
                CHITIETDIKEM e = db.CHITIETDIKEMs.Where(t => t.MADANHSACH.Equals(a.MADANHSACH) && t.MALOAIKHACH.Equals(a.MALOAIKHACH)).SingleOrDefault();
                e.GIOITINH = a.GIOITINH;
                e.NAMSINH = a.NAMSINH;
                e.HOTEN = a.HOTEN;
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool deleteCTDanhSach(CHITIETDIKEM a)
        {
            try
            {
                CHITIETDIKEM e = db.CHITIETDIKEMs.Where(t =>t.MACHITIET.Equals(a.MACHITIET) && t.MADANHSACH.Equals(a.MADANHSACH) && t.MALOAIKHACH.Equals(a.MALOAIKHACH)).SingleOrDefault();
                db.CHITIETDIKEMs.DeleteOnSubmit(e);
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
