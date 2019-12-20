using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLiTour
{
    public class DTO_ChiTietGiaTour
    {
        private string _MAGIAVE;
        public string MAGIAVE
        {
            get { return _MAGIAVE; }
            set { _MAGIAVE = value; }
        }
        private string _MALOAIKHACH;

        public string MALOAIKHACH
        {
            get { return _MALOAIKHACH; }
            set { _MALOAIKHACH = value; }
        }
        private float _GIA;

        public float GIA
        {
            get { return _GIA; }
            set { _GIA = value; }
        }
        private string _GHICHU;

        public string GHICHU
        {
            get { return _GHICHU; }
            set { _GHICHU = value; }
        }
        private string _TENLOAIKHACH;

        public string TENLOAIKHACH
        {
            get { return _TENLOAIKHACH; }
            set { _TENLOAIKHACH = value; }
        }
        public DTO_ChiTietGiaTour() { }
        public DTO_ChiTietGiaTour(string magiave, string makhach,string TenLoaiKhach ,float gia, string ghichu)
        {
            this.MAGIAVE = magiave;
            this.MALOAIKHACH = makhach;
            this.TENLOAIKHACH = TenLoaiKhach;
            this.GIA = gia;
            this.GHICHU = ghichu;
            
        }

    }
}
