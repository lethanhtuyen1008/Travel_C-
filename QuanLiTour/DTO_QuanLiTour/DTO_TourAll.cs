using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLiTour
{
    public class DTO_TourAll
    {
        private string _MaTour;
        private string _MaLoai;
        private string _TenTour;
        private int _SoNgay;
        private int _SoCho;

        public string MaTour
        {
            get { return _MaTour; }
            set { _MaTour = value; }
        }
        public string MaLoai
        {
            get { return _MaLoai; }
            set { _MaLoai = value; }
        }
        public string TenTour
        {
            get { return _TenTour; }
            set { _TenTour = value; }
        }
        public int SoNgay
        {
            get { return _SoNgay; }
            set { _SoNgay = value; }
        }
        public int SoCho
        {
            get { return _SoCho; }
            set { _SoCho = value; }
        }
        private string _TenLoai;

        public string TenLoai
        {
            get { return _TenLoai; }
            set { _TenLoai = value; }
        }
        private float _GIA;

        public float GIA
        {
            get { return _GIA; }
            set { _GIA = value; }
        }
        private string _TENHINH;

        public string TENHINH
        {
            get { return _TENHINH; }
            set { _TENHINH = value; }
        }
        public DTO_TourAll() { }
        public DTO_TourAll(string matour, string maloai, string tentour, int songay, int socho, float gia, string tenhinh)
        {
            this.MaTour = matour;
            this.MaLoai = maloai;
            this.TenTour = tentour;
            this.SoNgay = songay;
            this.SoCho = socho;
            this.GIA = gia;
            this.TENHINH = tenhinh;
        }
    }
}
