using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLiTour
{
    public class DTO_GiaTour
    {
        private string _MAGIAVE;

        public string MAGIAVE
        {
            get { return _MAGIAVE; }
            set { _MAGIAVE = value; }
        }
        private string _TENTOUR;

        public string TENTOUR
        {
            get { return _TENTOUR; }
            set { _TENTOUR = value; }
        }
        private string _TENLOAIKHACH;

        public string TENLOAIKHACH
        {
            get { return _TENLOAIKHACH; }
            set { _TENLOAIKHACH = value; }
        }
        private float _GIA;

        public float GIA
        {
            get { return _GIA; }
            set { _GIA = value; }
        }
        public DTO_GiaTour() { }
        public DTO_GiaTour(string magiave, string tentour, string tenloai, float gia)
        {
            this.MAGIAVE = magiave;
            this.TENTOUR = tentour;
            this.TENLOAIKHACH = tenloai;
            this.GIA = gia;
        }
    }
}
