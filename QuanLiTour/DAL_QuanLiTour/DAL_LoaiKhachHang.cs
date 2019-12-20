using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QuanLiTour
{
    public class DAL_LoaiKhachHang
    {
        DAL_QuanLiTravelDataContext db = new DAL_QuanLiTravelDataContext();
        public List<LOAIKHACH> getLoaiKhach()
        {
            return db.LOAIKHACHes.Select(t=>t).ToList<LOAIKHACH>();
        }
    }
}
