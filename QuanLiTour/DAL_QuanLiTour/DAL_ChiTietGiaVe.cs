using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QuanLiTour;

namespace DAL_QuanLiTour
{
    public class DAL_ChiTietGiaVe
    {
        DAL_QuanLiTravelDataContext db = new DAL_QuanLiTravelDataContext();
        public List<DTO_ChiTietGiaTour> getListChiTietGia(string magiave)
        {
            var a = from ctg in db.CHITIETGIAVEs
                    from kh in db.LOAIKHACHes
                    where ctg.MAGIAVE == magiave && kh.MALOAIKHACH == ctg.MALOAIKHACH
                    select new DTO_ChiTietGiaTour
                    {
                        MAGIAVE = ctg.MAGIAVE,
                        MALOAIKHACH = ctg.MALOAIKHACH,
                        TENLOAIKHACH = kh.TENLOAIKHACH,
                        GIA = float.Parse(ctg.GIA.ToString()),
                        GHICHU = ctg.GHICHU
                    };
            var kq = a.ToList().ConvertAll(t => new DTO_ChiTietGiaTour
            {
                MAGIAVE = t.MAGIAVE,
                MALOAIKHACH = t.MALOAIKHACH,
                TENLOAIKHACH = t.TENLOAIKHACH,
                GIA = float.Parse(t.GIA.ToString()),
                GHICHU = t.GHICHU
            });
            return kq.ToList<DTO_ChiTietGiaTour>();           
        }
        public bool addCTGV(CHITIETGIAVE a)
        {
            try
            {
                db.CHITIETGIAVEs.InsertOnSubmit(a);
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
