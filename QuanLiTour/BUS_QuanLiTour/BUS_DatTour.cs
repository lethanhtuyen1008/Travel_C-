using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QuanLiTour;
using DTO_QuanLiTour;
namespace BUS_QuanLiTour
{
    public class BUS_DatTour
    {
        DAL_DatTour dal = new DAL_DatTour();
        public List<DTO_TourDat> getTourDat()
        {
            return dal.getTourDat();
        }
        public bool addTourDat(TOURDAT a)
        {
            return dal.addDatTour(a);
        }
        public string ActionDatTour(string matour)
        {
            return dal.ActionDatTour(matour);
        }
        public bool updateTourDat(TOURDAT a)
        {
            return dal.UpdateDatTour(a);
        }
        public bool daleteTourDat(TOURDAT a)
        {
            return dal.deleteDatTour(a);
        }
        public string getMaTourDat()
        {
            return dal.getMaTourDat();
        }
        public bool deleteTD(string a)
        {
            return dal.deleteTD(a);
        }


    }
}
