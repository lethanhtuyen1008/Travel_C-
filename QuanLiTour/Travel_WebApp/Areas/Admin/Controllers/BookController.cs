using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BUS_QuanLiTour;
using DTO_QuanLiTour;

namespace Travel_WebApp.Areas.Admin.Controllers
{
    public class BookController : Controller
    {
        //
        // GET: /Admin/Book/
        BUS_DatTour bus = new BUS_DatTour();
        public ActionResult Index()
        {
            ViewData["data"] = bus.getTourDat();
            return View();
        }

        //
        // GET: /Admin/Book/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Admin/Book/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Admin/Book/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Admin/Book/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Admin/Book/Edit/5

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
        // GET: /Admin/Book/Delete/5

        public ActionResult Delete(string id)
        {
            if (bus.deleteTD(id))
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        //
        // POST: /Admin/Book/Delete/5

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
