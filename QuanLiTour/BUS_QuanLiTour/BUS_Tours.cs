using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL_QuanLiTour;
using DTO_QuanLiTour;

namespace BUS_QuanLiTour
{
    public class BUS_Tours
    {
        DAL_Tours dalTour = new DAL_Tours();
        public string getMaGiaVe(string matour)
        {
            return dalTour.getMaGiaVe(matour);
        }
        //public List<DTO_TourAll> getTourOnPage(string id, int sosp)
        //{
        //    dalTour.getTourOnPage(id, sosp);
        //}

        public List<DTO_TourAll> getAllTourWeb()
        {
            return dalTour.getAllTourWeb();
        }
        public bool updateTourWeb(TourEdit a)
        {
            return dalTour.updateTourWeb(a);
        }
        public List<DTO_TourAll> getTourLoai(string maloai)
        {
            return dalTour.getTourLoai(maloai);
        }
        public List<DTO_TourAll> getMaTourWeb(string matour)
        {
            return dalTour.getMaTourWeb(matour);
        }
        public DataTable getListTour()
        {
            return dalTour.getListTour();
        }
        public string getMaTour()
        {
            return dalTour.getMaTour();
        }
        public bool addTours(TourEdit a)
        {
            return dalTour.addTours(a);
        }
        public Byte[] getImageTour(string matour)
        {
            return dalTour.getImageTour(matour);
        }
        public bool updateTours(TourEdit a)
        {
            return dalTour.updateTours(a);
        }
        public bool deleteTour(string a)
        {
            return dalTour.deleteTour(a);
        }
        public DataTable getAllTour()
        {
            return dalTour.getAllTour();
        }
        public List<TOUR> getAll()
        {
            return dalTour.getAll();
        }

    }
}
