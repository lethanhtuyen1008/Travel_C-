using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL_QuanLiTour;
using DTO_QuanLiTour;
using System.Threading.Tasks;

namespace BUS_QuanLiTour
{
    public class BUS_DiaDiem
    {
        DAL_DiaDiem dal = new DAL_DiaDiem();
        public DIADIEMDULICH getDiaDiem(string ma)
        {
            return dal.getDiaDiem(ma);
        }
        public List<DIADIEMDULICH> getAllDD()
        {
            return dal.getAllDD();
        }
    }
}
