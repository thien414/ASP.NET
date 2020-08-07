using DA_ASP.Models;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DA_ASP.Controllers
{
    public class GioHangController : Controller
    {
        dbBanDTDataContext data = new dbBanDTDataContext();

        public List<GioHang> layGioHang()
        {
            List<GioHang> listGH = Session["GioHang"] as List<GioHang>;
            if(listGH == null)
            {
                listGH = new List<GioHang>();
                Session["GioHang"] = listGH;
            }
            return listGH;
        }
        // GET: GioHang
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AddGioHang(int iMaSP, string strURL)
        {
            List<GioHang> listGH = layGioHang();

            GioHang sp = listGH.Find(n => n.iMaSP == iMaSP);
            if(sp == null)
            {
                sp = new GioHang(iMaSP);
                listGH.Add(sp);
                return Redirect(strURL);
            }
            else
            {
                sp.iSoLuong++;
                return Redirect(strURL);
            }
        }

        public int TongSoLuong()
        {
            int iTongSoLuong = 0;
            List<GioHang> listGH = Session["GioHang"] as List<GioHang>;
            if (listGH != null)
            {
                iTongSoLuong = listGH.Sum(n => n.iSoLuong);
            }
            return iTongSoLuong;
        }

        public double TongTien()
        {
            double iTongTien = 0;
            List<GioHang> listGH = Session["GioHang"] as List<GioHang>;
            if (listGH != null)
            {
                iTongTien = listGH.Sum(n => n.dThanhTien);
            }
            return iTongTien;
        }

        public ActionResult GioHang()
        {
            List<GioHang> ListGH = layGioHang();
            if(ListGH.Count == 0)
            {
                return RedirectToAction("Index", "Shop");
            }
            ViewBag.Tongsoluong = TongSoLuong();
            ViewBag.Tongtien = TongTien();
            return View(ListGH);
        }

        public ActionResult GioHangView()
        {
            ViewBag.Tongsoluong = TongSoLuong();
            ViewBag.Tongtien = TongTien();
            return PartialView();
        }
    }
}