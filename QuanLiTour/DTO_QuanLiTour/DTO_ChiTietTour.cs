using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLiTour
{
    public class DTO_ChiTietTour
    {
        private string _TENTOUR;
        private string _MADIADIEM;

        public string MADIADIEM
        {
            get { return _MADIADIEM; }
            set { _MADIADIEM = value; }
        }
        public string TENTOUR
        {
            get { return _TENTOUR; }
            set { _TENTOUR = value; }
        }
        private string _TENDIADIEM;

        public string TENDIADIEM
        {
            get { return _TENDIADIEM; }
            set { _TENDIADIEM = value; }
        }
        private string _TINH;

        public string TINH
        {
            get { return _TINH; }
            set { _TINH = value; }
        }
        private string _TENQUOCGIA;

        public string TENQUOCGIA
        {
            get { return _TENQUOCGIA; }
            set { _TENQUOCGIA = value; }
        }
        private string _GHICHU;

        public string GHICHU
        {
            get { return _GHICHU; }
            set { _GHICHU = value; }
        }
        public DTO_ChiTietTour( string tentour, string tendiadiem, string tinh, string tenquocgia, string ghichu, string madiadiem)
        {
            this.TENTOUR = tentour;
            this.TENDIADIEM = tendiadiem;
            this.MADIADIEM = madiadiem;
            this.TINH = tinh;
            this.TENQUOCGIA = tenquocgia;
            this.GHICHU = ghichu;
        }
        public DTO_ChiTietTour() { }
    }
}
