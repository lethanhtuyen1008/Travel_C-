using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Travel_WebApp.Controllers
{
    public class LogoutController : Controller
    {
        //
        // GET: /Logout/

        public ActionResult Index()
        {
            Session["user"] = null;
            return RedirectToAction("Index", "Home");
        }

        //
        // GET: /Logout/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Logout/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Logout/Create

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
        // GET: /Logout/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Logout/Edit/5

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
        // GET: /Logout/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Logout/Delete/5

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
