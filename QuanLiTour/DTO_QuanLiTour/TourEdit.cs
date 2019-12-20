using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLiTour
{
    public class TourEdit
    {
        private string _MaTour;
        private string _MaLoai;
        private string _TenTour;
        private int _SoNgay;
        private int _SoCho;
        private byte[] _Hinh;
        private string _MaGiaVe;

        public string MaGiaVe
        {
            get { return _MaGiaVe; }
            set { _MaGiaVe = value; }
        }

        public string Matour
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
        public byte[] Hinh
        {
            get { return _Hinh; }
            set { _Hinh = value; }
        }
        private string _TenLoai;

        public string TenLoai
        {
            get { return _TenLoai; }
            set { _TenLoai = value; }
        }
        public TourEdit() { }
        public TourEdit(string matour, string maloai, string tentour, int songay, int socho, byte[] hinh, string magiave)
        {
            this.Matour = matour;
            this.MaLoai = maloai;
            this.TenTour = tentour;
            this.SoNgay = songay;
            this.SoCho = socho;
            this.Hinh = hinh;
            this.MaGiaVe = magiave;
        }
    }
}
