using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QuanLiTour;
namespace DAL_QuanLiTour
{
    public class DAL_GiaTour
    {
        DAL_QuanLiTravelDataContext db = new DAL_QuanLiTravelDataContext();
        public List<GIAVE> getGiaTour() {
            //var gia = from g in db.CHITIETGIAVEs
            //          from t in db.TOURs
            //          from lk in db.LOAIKHACHes 
            //          where 
            //          select new DTO_GiaTour
            //          {
            //              MAGIAVE = g.MAGIAVE,
            //              TENTOUR = t.TENTOUR,
            //              TENLOAIKHACH = lk.TENLOAIKHACH,
            //              GIA = float.Parse(g.GIA.ToString())
            //          };
            //var kq = gia.ToList().ConvertAll(t => new DTO_GiaTour
            //{
            //    MAGIAVE = t.MAGIAVE,
            //    TENTOUR = t.TENTOUR,
            //    TENLOAIKHACH = t.TENLOAIKHACH,
            //    GIA = t.GIA,
            //});
            //return kq.ToList<DTO_GiaTour>();
            var a = db.GIAVEs.Select(t => t).ToList<GIAVE>();
            return a.ToList<GIAVE>();
        }
        public bool addGiaVe(GIAVE a)
        {
            try
            {
                db.GIAVEs.InsertOnSubmit(a);
                db.SubmitChanges();
                return false;
            }
            catch
            {
                return false;
            }
        }
        public List<CHITIETGIAVE> getChiTietGia(string magiave)
        {
            var a = db.CHITIETGIAVEs.Where(t => t.MAGIAVE.Equals(magiave)).ToList<CHITIETGIAVE>();
            return a.ToList<CHITIETGIAVE>();
        }
        public string getMaGiave()
        {
            string ma = "GV";
            var a = db.GIAVEs.Select(t => t).ToList<GIAVE>();
            int i = a.Count;
            string Str = a[i - 1].MAGIAVE.ToString();
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
