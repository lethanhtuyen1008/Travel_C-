using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BUS_QuanLiTour;
using DAL_QuanLiTour;
using DTO_QuanLiTour;

namespace Travel_WebApp.Areas.Admin.Controllers {
    public class TourController : Controller {
        //
        // GET: /Admin/Tours/

        BUS_Tours bus = new BUS_Tours ();
        BUS_ChuongTrinhTour busCT = new BUS_ChuongTrinhTour();
        BUS_ChiTietChuongTrinh busCTCT = new BUS_ChiTietChuongTrinh();
        BUS_DiaDiem busdd = new BUS_DiaDiem();
        BUS_KhachSan busKS = new BUS_KhachSan();
        public ActionResult Index () {
            var a = bus.getAllTourWeb ();
            return View (a);
        }

        //
        // GET: /Admin/Tours/Details/5

        public ActionResult Details (int id) {
            return View ();
        }

        //
        // GET: /Admin/Tours/Create

        public ActionResult Create () {
            return View ();
        }

        //
        // POST: /Admin/Tours/Create

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
        // GET: /Admin/Tour/Edit/5

        public ActionResult Edit (string id) {
            ViewData["chuongtrinh"] = busCT.getListChuongTrinhTour (id);
            ViewData["chitiet"] = busCTCT.getAllCTChuongTrinh ();
            ViewData["diadiem"] = busdd.getAllDD ();
            ViewData["khachsan"] = busKS.getKhachSan();
            ViewData["a"] = bus.getMaTourWeb (id);
            return View ();
        }

        //
        // POST: /Admin/Tour/Edit/5

        [HttpPost]
        public ActionResult Edit (string id, FormCollection f) {
            try {
                
                string tentour = f["ten_tour"];
                string gia = f["gia_tour"];
                string socho = f["so_cho"];
                string songay = f["so_ngay"];
                string loai = f["loai_tour"];
                TourEdit a = new TourEdit();
                a.Matour = id;
                a.TenTour = tentour;
                a.SoCho = int.Parse(socho);
                a.SoNgay = int.Parse(songay);
                a.MaLoai = loai;
                a.MaGiaVe = "GV0001";
                if (bus.updateTourWeb(a))
                    return RedirectToAction("Index");
                else
                    return RedirectToAction("edit", "tour");
            } catch {
                return View ();
            }
        }

        //
        // GET: /Admin/Tours/Delete/5

        public ActionResult Delete (int id) {
            return View ();
        }

        //
        // POST: /Admin/Tours/Delete/5

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