using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DTO_QuanLiTour;
using BUS_QuanLiTour;

namespace Travel_WebApp.Controllers
{
    public class SigninController : Controller
    {
        //
        // GET: /Signin/
        BUS_QLNguoiDung nd = new BUS_QLNguoiDung();
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Signin/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Signin/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Signin/Create

        [HttpPost]
        public ActionResult Create(FormCollection p)
        {
            try
            {
                // TODO: Add insert logic here
                string tendangnhap = p["username"];
                string matkhau = p["pwd"];
                string ho = p["ho"];
                string ten = p["ten"];
                string gt = p["gioitinh"];
                DTO_QLNguoiDung a = new DTO_QLNguoiDung();
                a.TenDangNhap = tendangnhap;
                a.MatKhau = matkhau;
                a.NamSinh = 1998;
                a.Ho = ho;
                a.Ten = ten;
                a.GioiTinh = gt;
                a.TinhTrang = 1;
                a.Luong = 100000;
                if (nd.AddNguoiDung(a))
                {
                    return RedirectToAction("Index", "Login");
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Signin/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Signin/Edit/5

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
        // GET: /Signin/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Signin/Delete/5

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
