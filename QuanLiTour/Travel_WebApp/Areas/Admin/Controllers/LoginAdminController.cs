using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Travel_WebApp.Areas.Admin.Controllers
{
    public class LoginAdminController : Controller
    {
        //
        // GET: /Admin/LoginAdmin/

        public ActionResult Index()
        {
            if(Session["admin"] == null)
                return View();
            else
                return RedirectToAction("Index", "Homes");
        }

        //
        // GET: /Admin/LoginAdmin/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Admin/LoginAdmin/Create

        public ActionResult Create()
        {
            Session["admin"] = null;
            return RedirectToAction("Index", "LoginAdmin");
        }

        //
        // POST: /Admin/LoginAdmin/Create

        [HttpPost]
        public ActionResult Create(FormCollection f)
        {
            try
            {
                
                string user = f["username"];
                string pass = f["password"];
                if (user.Equals("admin") && pass.Equals("123456"))
                {
                    Session["admin"] = "Admin";
                    return RedirectToAction("Index", "Homes");
                }
                else
                {
                    return RedirectToAction("Index");
                }
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Admin/LoginAdmin/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Admin/LoginAdmin/Edit/5

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
        // GET: /Admin/LoginAdmin/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Admin/LoginAdmin/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
           {
               Session["admin"] = null;
                // TODO: Add delete logic here
               return RedirectToAction("Index", "LoginAdmin");
            }
            catch
            {
                return View();
            }
        }
    }
}
