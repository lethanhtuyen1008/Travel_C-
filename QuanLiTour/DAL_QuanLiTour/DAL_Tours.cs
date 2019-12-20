using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO_QuanLiTour;

namespace DAL_QuanLiTour
{
    public class DAL_Tours
    {
        DAL_QuanLiTravelDataContext db = new DAL_QuanLiTravelDataContext();
        public DataTable  getListTour()
        {
            var a = from t in db.TOURs
                    from l in db.LICHKHOIHANHs
                    from lt in db.LOAITOURs
                    from g in db.GIAVEs
                    where t.MATOUR == l.MATOUR && lt.MALOAI == t.MALOAI && t.MAGIAVE == g.MAGIAVE
                    select new
                    {
                        MaTour = t.MATOUR,
                        MaLoai = t.MALOAI,
                        TenLoai = lt.TENLOAI,
                        TenTour = t.TENTOUR,
                        SoNgay = t.SONGAY,
                        SoCho = int.Parse(t.SOCHO.ToString()),
                        Hinh = t.HINH,
                        MaGiaVe = t.MAGIAVE,
                        GiaVe = g.TONGGIA
                    };
            var resultTable = new DataTable();
            bool firstPass = true;
            foreach (var item in a)
            {
                if (firstPass)
                {
                    Array.ForEach(item.GetType().GetProperties(), p => resultTable.Columns.Add(new DataColumn(p.Name)));
                    firstPass = false;
                }
                var newRow = resultTable.NewRow();
                Array.ForEach(item.GetType().GetProperties(), p => newRow[p.Name] = p.GetValue(item, null));
                resultTable.Rows.Add(newRow);
            }
            return resultTable;
        }
        public DataTable getAllTour()
        {
            var a = db.TOURs.Select(t => t);
            var resultTable = new DataTable();
            bool firstPass = true;
            foreach (var item in a)
            {
                if (firstPass)
                {
                    Array.ForEach(item.GetType().GetProperties(), p => resultTable.Columns.Add(new DataColumn(p.Name)));
                    firstPass = false;
                }
                var newRow = resultTable.NewRow();
                Array.ForEach(item.GetType().GetProperties(), p => newRow[p.Name] = p.GetValue(item, null));
                resultTable.Rows.Add(newRow);
            }
            return resultTable;
        }
        //public List<DTO_TourAll> getTourOnPage(string id,int sosp)
        //{
        //    //12
        //    //2

        //}

        public List<DTO_TourAll> getAllTourWeb()
        {
            var a = from t in db.TOURs
                    from g in db.GIAVEs
                    from lt in db.LOAITOURs
                    where t.MAGIAVE == g.MAGIAVE && t.MALOAI == lt.MALOAI
                    select new 
                    {
                        MaTour = t.MATOUR,
                        MaLoai = t.MALOAI,
                        TenLoai = lt.TENLOAI,
                        TenTour = t.TENTOUR,
                        SoNgay = int.Parse(t.SONGAY.ToString()),
                        SoCho = int.Parse(t.SOCHO.ToString()),
                        GIA = float.Parse(g.TONGGIA.ToString()),
                        TENHINH = t.TENHINH
                    };
            var kq = a.ToList().ConvertAll(t => new DTO_TourAll
            {
                MaTour = t.MaTour,
                MaLoai = t.MaLoai,
                TenLoai = t.TenLoai,
                TenTour = t.TenTour,
                SoNgay = int.Parse(t.SoNgay.ToString()),
                SoCho = int.Parse(t.SoCho.ToString()),
                GIA = float.Parse(t.GIA.ToString()),
                TENHINH = t.TENHINH
            });
            return kq.ToList<DTO_TourAll>();
        }
        public List<DTO_TourAll> getTourLoai(string maloai)
        {
            var a = from t in db.TOURs
                    from g in db.GIAVEs
                    from lt in db.LOAITOURs
                    where t.MAGIAVE == g.MAGIAVE && 
                                t.MALOAI == lt.MALOAI && 
                                t.MALOAI == maloai
                    select new
                    {
                        MaTour = t.MATOUR,
                        MaLoai = t.MALOAI,
                        TenLoai = lt.TENLOAI,
                        TenTour = t.TENTOUR,
                        SoNgay = int.Parse(t.SONGAY.ToString()),
                        SoCho = int.Parse(t.SOCHO.ToString()),
                        GIA = float.Parse(g.TONGGIA.ToString()),
                        TENHINH = t.TENHINH
                    };
            var kq = a.ToList().ConvertAll(t => new DTO_TourAll
            {
                MaTour = t.MaTour,
                MaLoai = t.MaLoai,
                TenLoai = t.TenLoai,
                TenTour = t.TenTour,
                SoNgay = int.Parse(t.SoNgay.ToString()),
                SoCho = int.Parse(t.SoCho.ToString()),
                GIA = float.Parse(t.GIA.ToString()),
                TENHINH = t.TENHINH
            });
            return kq.ToList<DTO_TourAll>();
        }
        public List<DTO_TourAll> getMaTourWeb(string matour)
        {
            var a = from t in db.TOURs
                    from g in db.GIAVEs
                    from lt in db.LOAITOURs
                    where t.MAGIAVE == g.MAGIAVE &&
                                t.MALOAI == lt.MALOAI &&
                                t.MATOUR == matour
                    select new
                    {
                        MaTour = t.MATOUR,
                        MaLoai = t.MALOAI,
                        TenLoai = lt.TENLOAI,
                        TenTour = t.TENTOUR,
                        SoNgay = int.Parse(t.SONGAY.ToString()),
                        SoCho = int.Parse(t.SOCHO.ToString()),
                        GIA = float.Parse(g.TONGGIA.ToString()),
                        TENHINH = t.TENHINH
                    };
            var kq = a.ToList().ConvertAll(t => new DTO_TourAll
            {
                MaTour = t.MaTour,
                MaLoai = t.MaLoai,
                TenLoai = t.TenLoai,
                TenTour = t.TenTour,
                SoNgay = int.Parse(t.SoNgay.ToString()),
                SoCho = int.Parse(t.SoCho.ToString()),
                GIA = float.Parse(t.GIA.ToString()),
                TENHINH = t.TENHINH
            });
            return kq.ToList<DTO_TourAll>();
        }
        public List<TOUR> getAll()
        {
            var a = db.TOURs.Select(t => t).ToList<TOUR>();
            return a.ToList<TOUR>();
        }
        public string getMaGiaVe(string matour)
        {
            var a = db.TOURs.Where(t=>t.MATOUR.Equals(matour)).ToList<TOUR>();
            string ma = a[0].MAGIAVE.ToString();
            return ma;
        }
        public string getMaTour()
        {
            string ma = "MT";
            var a = db.TOURs.Select(t => t).ToList<TOUR>();
            int i = a.Count;
            string Str = a[i - 1].MATOUR.ToString();
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
        public Byte[] getImageTour(string matour)
        {
            TOUR a = db.TOURs.Where(t => t.MATOUR.Equals(matour)).SingleOrDefault();
            if (a.HINH.ToArray().Length == 0)
            {
                return null;
            }
            else
            {
                byte[] x = a.HINH.ToArray();
                return x;
            }
        }
        public bool addTours(TourEdit a)
        {
            try
            {
                TOUR add = new TOUR();
                add.MATOUR = a.Matour;
                add.MALOAI = a.MaLoai;
                add.TENTOUR = a.TenTour;
                add.SONGAY = a.SoNgay;
                add.SOCHO = a.SoCho;
                add.HINH = a.Hinh;
                add.MAGIAVE = a.MaGiaVe;
                add.TENHINH = "hinh1.jpg";
                db.TOURs.InsertOnSubmit(add);

                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool updateTours(TourEdit a)
        {
            try
            {
                TOUR add = db.TOURs.Where(t => t.MATOUR.Equals(a.Matour)).SingleOrDefault();
                add.MALOAI = a.MaLoai;
                add.TENTOUR = a.TenTour;
                add.SONGAY = a.SoNgay;
                add.SOCHO = a.SoCho;
                add.HINH = a.Hinh;
                add.MAGIAVE = a.MaGiaVe;
                add.TENHINH = "hinh1.jpg";
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool updateTourWeb(TourEdit a)
        {
            try
            {
                TOUR add = db.TOURs.Where(t => t.MATOUR.Equals(a.Matour)).SingleOrDefault();
                add.MALOAI = a.MaLoai;
                add.TENTOUR = a.TenTour;
                add.SONGAY = a.SoNgay;
                add.SOCHO = a.SoCho;
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool deleteTour(string matour)
        {
            try
            {
                TOUR a = db.TOURs.Where(t => t.MATOUR.Equals(matour)).SingleOrDefault();
                db.TOURs.DeleteOnSubmit(a);
                db.SubmitChanges();
                return true;
            }
            catch { return false; }
        }

    }
}
