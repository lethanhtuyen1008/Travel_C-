using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Travel_WebApp.Areas.Admin.Controllers {
    public class HomesController : Controller {
        //
        // GET: /Admin/Homes/

        public ActionResult Index () {
            if (Session["admin"] != null)
                return View();
            else
                return RedirectToAction("Index", "LoginAdmin");
        }

        //
        // GET: /Admin/Homes/Details/5

        public ActionResult Details (int id) {
            return View ();
        }

        //
        // GET: /Admin/Homes/Create

        public ActionResult Create () {
            return View ();
        }

        //
        // POST: /Admin/Homes/Create

        [HttpPost]
        public ActionResult Create (FormCollection collection) {
            try {
                // TODO: Add insert logic here

                return RedirectToAction ("Index");
            } catch {
                return View ();
            }
        }

        //
        // GET: /Admin/Homes/Edit/5

        public ActionResult Edit (int id) {
            return View ();
        }

        //
        // POST: /Admin/Homes/Edit/5

        [HttpPost]
        public ActionResult Edit (int id, FormCollection collection) {
            try {
                // TODO: Add update logic here

                return RedirectToAction ("Index");
            } catch {
                return View ();
            }
        }

        //
        // GET: /Admin/Homes/Delete/5

        public ActionResult Delete (int id) {
            return View ();
        }

        //
        // POST: /Admin/Homes/Delete/5

        [HttpPost]
        public ActionResult Delete (int id, FormCollection collection) {
            try {
                // TODO: Add delete logic here

                return RedirectToAction ("Index");
            } catch {
                return View ();
            }
        }
    }
}