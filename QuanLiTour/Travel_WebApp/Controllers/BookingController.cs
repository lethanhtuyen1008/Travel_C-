using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BUS_QuanLiTour;
using DAL_QuanLiTour;

namespace Travel_WebApp.Controllers
{
    public class BookingController : Controller
    {
        //
        // GET: /Booking/
        BUS_Tours bus = new BUS_Tours();
        BUS_DatTour bustd = new BUS_DatTour();
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Booking/Details/5

        public ActionResult Details(string id)
        {
            return View();
        }

        //
        // GET: /Booking/Create

        public ActionResult Create()
        {
            return View();
        }
        // 

        //
        // POST: /Booking/Create

        [HttpPost]
        public ActionResult Create(FormCollection p)
        {
            try
            {
                string loaitt = p["loaithanhtoan"];
                string diemdon = p["diemdon"];
                string ngaydat = p["ngaydat"];
                string ten = p["name"];
                string trangthai = p["trangthai"];
                string tongtien = p["tongtien"];
                string ghichu = p["ghichu"];

                TOURDAT a = new TOURDAT();

                a.MATOURDAT = bustd.getMaTourDat();
                a.MALICH = "ML0002";
                a.DIEMDON = "Sai Gon";
                a.MADANHSACH = "DS0002";
                a.MAKHACHHANG = "KH0002";
                a.MALOAITT = "TT0001";
                DateTime dt = Convert.ToDateTime("2019-12-17 00:00:00.000");
                DateTime d = new DateTime();
                a.NGAYDAT = dt;
                a.TONGTIEN = 4500000;
                a.TRANGTHAI = "hoàn thành";
                bool b = bustd.addTourDat(a);
                bool c = b;
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Booking/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Booking/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Booking/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Booking/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
