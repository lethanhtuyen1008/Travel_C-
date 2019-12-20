using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QuanLiTour;
namespace DAL_QuanLiTour
{
    public class DAL_ChiTietTour
    {
        DAL_QuanLiTravelDataContext db = new DAL_QuanLiTravelDataContext();
        public List<DTO_ChiTietTour> getChiTietThamQuan(string matour)
        {
            var ls = from ct in db.CHITIETTHAMQUANs
                     from tou in db.TOURs
                     from dd in db.DIADIEMDULICHes
                     from qg in db.QUOCGIAs
                     from t in db.TINHs
                     where ct.MADIADIEM == dd.MADIADIEM &&
                            dd.MATINH == t.MATINH &&
                            tou.MATOUR == ct.MATOUR &&
                            ct.MATOUR == matour &&
                            qg.MAQUOCGIA == dd.MAQUOCGIA 
                     select new {
                         tentour = tou.TENTOUR,
                         tendiadiem = dd.TENDIADIEM,
                         tinh = t.TENTINH,
                         quocgia = qg.TENQUOCGIA,
                         ghichu = ct.GHICHU,
                         madiadiem = ct.MADIADIEM
                     };
            var kq = ls.ToList().ConvertAll(t => new DTO_ChiTietTour
            {
                TENTOUR = t.tentour,
                TENDIADIEM = t.tendiadiem,
                TINH = t.tinh,
                TENQUOCGIA = t.quocgia,
                GHICHU = t.ghichu,
                MADIADIEM = t.madiadiem
            });
            return kq.ToList<DTO_ChiTietTour>();           
        }
        public bool getLoaiTour(string matour)
        {
            var x = from t in db.TOURs
                        where t.MATOUR == matour
                        select t;
            List<TOUR> k = x.ToList<TOUR>();
            string l = k[0].MALOAI;
            if (l.Equals("LT0001") == false)
                return true;
            else
                return false;
        }
        public List<QUOCGIA> getQuocGia()
        {
            var x = db.QUOCGIAs.Select(t => t);
            return x.ToList<QUOCGIA>();
        }
        public List<TINH> getTinh()
        {
            var x = db.TINHs.Select(t => t);
            return x.ToList<TINH>();
        }
        public bool addCTTour(CHITIETTHAMQUAN a)
        {
            try
            {
                db.CHITIETTHAMQUANs.InsertOnSubmit(a);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public List<DIADIEMDULICH> getListDiaDiem(string matinh)
        {
            var x = db.DIADIEMDULICHes.Where(t => t.MATINH.Equals(matinh));
            return x.ToList<DIADIEMDULICH>();
        }
        public List<DIADIEMDULICH> getDiaDiem()
        {
            var x = db.DIADIEMDULICHes.Select(t => t);
            return x.ToList<DIADIEMDULICH>();
        }
        public bool updateCTTour(CHITIETTHAMQUAN a)
        {
            try
            {
                CHITIETTHAMQUAN update = db.CHITIETTHAMQUANs.Where(t => t.MATOUR.Equals(a.MATOUR) && t.MADIADIEM.Equals(a.MADIADIEM)).SingleOrDefault();
                update.MADIADIEM = a.MADIADIEM;
                update.GHICHU = a.GHICHU;
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool deleteCTTour(CHITIETTHAMQUAN a)
        {
            try
            {
                CHITIETTHAMQUAN update = db.CHITIETTHAMQUANs.Where(t => t.MATOUR.Equals(a.MATOUR) && t.MADIADIEM.Equals(a.MADIADIEM)).SingleOrDefault();
                db.CHITIETTHAMQUANs.DeleteOnSubmit(update);
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
