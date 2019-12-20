using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL_QuanLiTour;
using System.Threading.Tasks;

namespace BUS_QuanLiTour
{
    public class BUS_LichKhoiHanh
    {
        DAL_LichKhoiHanh dal = new DAL_LichKhoiHanh();
        public List<LICHKHOIHANH> getLichKhoiHanh()
        {
            return dal.getLichKhoiHanh();
        }
        public List<LICHKHOIHANH> getLichKhoiHanhTour(string mat)
        {
            return dal.getLichKhoiHanhTour(mat);
        }
        public string getMaLich()
        {
            return dal.getMaLich();
        }
        public string getMaTour(string malich)
        {
            return dal.getMaTour(malich);
        }
        public bool addLichKhoiHanh(LICHKHOIHANH a)
        {
            return dal.addLichKhoihanh(a);
        }
        public bool editLichKhoiHanh(LICHKHOIHANH a)
        {
            return dal.editLichKhoihanh(a);
        }
        public bool deleteLichKhoiHanh(string c)
        {
            return dal.deleteLichKhoiHanh(c);
        }
    }
}
