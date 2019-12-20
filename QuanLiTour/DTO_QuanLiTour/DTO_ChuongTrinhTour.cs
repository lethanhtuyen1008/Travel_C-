using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLiTour
{
    public class DTO_ChuongTrinhTour
    {
        private string _MACHUONGTRINH;

        public string MACHUONGTRINH
        {
            get { return _MACHUONGTRINH; }
            set { _MACHUONGTRINH = value; }
        }

        private string _MATOUR;

        public string MATOUR
        {
            get { return _MATOUR; }
            set { _MATOUR = value; }
        }

        private string _MAKHACHSAN;

        public string MAKHACHSAN
        {
            get { return _MAKHACHSAN; }
            set { _MAKHACHSAN = value; }
        }

        private string _TENCHUONGTRINH;

        public string TENCHUONGTRINH
        {
            get { return _TENCHUONGTRINH; }
            set { _TENCHUONGTRINH = value; }
        }

        private System.Nullable<System.DateTime> _NGAY;

        public System.Nullable<System.DateTime> NGAY
        {
            get { return _NGAY; }
            set { _NGAY = value; }
        }

        private string _GHICHU;

        public string GHICHU
        {
            get { return _GHICHU; }
            set { _GHICHU = value; }
        }
        private string _TENTOUR;

        public string TENTOUR
        {
            get { return _TENTOUR; }
            set { _TENTOUR = value; }
        }
        private string _TENKHACHSAN;

        public string TENKHACHSAN
        {
            get { return _TENKHACHSAN; }
            set { _TENKHACHSAN = value; }
        }
    }
}
