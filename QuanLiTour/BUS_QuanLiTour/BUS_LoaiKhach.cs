using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QuanLiTour;
namespace BUS_QuanLiTour
{
    public class BUS_LoaiKhach
    {
        DAL_LoaiKhachHang dal = new DAL_LoaiKhachHang();
        public List<LOAIKHACH> getLoaiKhach()
        {
            return dal.getLoaiKhach();
        }
    }
}
