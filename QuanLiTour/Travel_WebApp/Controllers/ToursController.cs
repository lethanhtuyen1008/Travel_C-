using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL_QuanLiTour;
using BUS_QuanLiTour;

namespace Travel_WebApp.Controllers
{
    public class ToursController : Controller
    {
        //
        // GET: /Tours/
        BUS_Tours bus = new BUS_Tours();
        
        public ActionResult Index()
        {
            var a = bus.getAllTourWeb();
            return View(a);
        }

        //
        // GET: /Tours/Details/5

        public ActionResult Details(string id)
        {
            BUS_ChuongTrinhTour busCT = new BUS_ChuongTrinhTour();
            BUS_ChiTietChuongTrinh busCTCT = new BUS_ChiTietChuongTrinh();
            BUS_DiaDiem busdd = new BUS_DiaDiem();
            ViewData["chuongtrinh"] = busCT.getListChuongTrinhTour(id);
            ViewData["chitiet"] = busCTCT.getAllCTChuongTrinh();
            ViewData["diadiem"] = busdd.getAllDD();
            ViewData["a"] = bus.getMaTourWeb(id);
            return View();
        }

        public ActionResult Page(string id)
        {
            //int sosp_page = 12;
            //var a = bus.getTourOnPage(id, sosp_page);
            return View ();
        }

        public ActionResult Loai(string maloai)
        {
            var b = bus.getAllTourWeb();
            return View(b);
        }
        //
        // GET: /Tours/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Tours/Create

        [HttpPost]
        public ActionResult Create(TOUR a)
        {
            try
            {
                
                //FormCollection.
                return RedirectToAction("Tours");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Tours/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Tours/Edit/5

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
        // GET: /Tours/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Tours/Delete/5

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
