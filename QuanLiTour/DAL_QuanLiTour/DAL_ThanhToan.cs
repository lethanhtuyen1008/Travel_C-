using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QuanLiTour
{
    public class DAL_ThanhToan
    {
        DAL_QuanLiTravelDataContext db = new DAL_QuanLiTravelDataContext();
        public List<LOAITHANHTOAN> getListThanhToan()
        {
            return db.LOAITHANHTOANs.Select(t => t).ToList<LOAITHANHTOAN>();
        }
    }
}
