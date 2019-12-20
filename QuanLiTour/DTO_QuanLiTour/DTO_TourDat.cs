using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLiTour
{
    public class DTO_TourDat
    {
        private string _MATOURDAT;

        public string MATOURDAT
        {
            get { return _MATOURDAT; }
            set { _MATOURDAT = value; }
        }
        private string _TENTOUR;

        public string TENTOUR
        {
            get { return _TENTOUR; }
            set { _TENTOUR = value; }
        }
        
        private string _MALICH;

        public string MALICH
        {
            get { return _MALICH; }
            set { _MALICH = value; }
        }
        private string _TENLICH;

        public string TENLICH
        {
            get { return _TENLICH; }
            set { _TENLICH = value; }
        }
        private string _MADANHSACH;

        public string MADANHSACH
        {
            get { return _MADANHSACH; }
            set { _MADANHSACH = value; }
        }
        private string _TENDANHSACH;

        public string TENDANHSACH
        {
            get { return _TENDANHSACH; }
            set { _TENDANHSACH = value; }
        }
        private string _MAKHACHHANG;

        public string MAKHACHHANG
        {
            get { return _MAKHACHHANG; }
            set { _MAKHACHHANG = value; }
        }
        private string _TENKHACHHANG;

        public string TENKHACHHANG
        {
            get { return _TENKHACHHANG; }
            set { _TENKHACHHANG = value; }
        }
        private string _MALOAITT;

        public string MALOAITT
        {
            get { return _MALOAITT; }
            set { _MALOAITT = value; }
        }
        private string _TENLOAITT;

        public string TENLOAITT
        {
            get { return _TENLOAITT; }
            set { _TENLOAITT = value; }
        }
        private string _DIEMDON;

        public string DIEMDON
        {
            get { return _DIEMDON; }
            set { _DIEMDON = value; }
        }
        private DateTime _NGAYDAT;

        public DateTime NGAYDAT
        {
            get { return _NGAYDAT; }
            set { _NGAYDAT = value; }
        }
        private string _TRANGTHAI;

        public string TRANGTHAI
        {
            get { return _TRANGTHAI; }
            set { _TRANGTHAI = value; }
        }
        private float _TONGTIEN;

        public float TONGTIEN
        {
            get { return _TONGTIEN; }
            set { _TONGTIEN = value; }
        }
        public DTO_TourDat()
        {
        }
        public DTO_TourDat(string mat, string tent, string mal, string tenlich, string mads, string tends, string mak, string tenkh, string matt, string tentt, string dd, DateTime ngay, string tt, float tien)
        {
            this.MATOURDAT = mat;
            this.TENTOUR = tent;
            this.MALICH = mal;
            this.TENLICH = tenlich;
            this.MADANHSACH = mads;
            this.TENDANHSACH = tends;
            this.MAKHACHHANG = mak;
            this.TENKHACHHANG = tenkh;
            this.MALOAITT = matt;
            this.TENLOAITT = tentt;
            this.DIEMDON = dd;
            this.NGAYDAT = ngay;
            this.TRANGTHAI = tt;
            this.TONGTIEN = tien;
        }


    }
}
