using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QuanLiTour;
using DTO_QuanLiTour;

namespace BUS_QuanLiTour
{
    public class BUS_ThanhToan
    {
        DAL_ThanhToan dal = new DAL_ThanhToan();
        public List<LOAITHANHTOAN> getThanhToan()
        {
            return dal.getListThanhToan();
        }
    }
}
