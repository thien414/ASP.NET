using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QLBanDienThoai.Models;

namespace QLBanDienThoai.Controllers
{
    public class ShopController : Controller
    {
        dbBanDTDataContext data = new dbBanDTDataContext();

        private List<SANPHAM> listSP(int sl)
        {
            return data.SANPHAMs.Take(sl).ToList();
        }

        // GET: Shop
        public ActionResult Index()
        {
            return View(from sp in data.SANPHAMs where sp.MaSX == "AS" select sp);
        }
        public ActionResult Viewa()
        {
            return View();
        }
        public ActionResult HangMenu()
        {
            return View(from hang in data.NHASXes select hang);
        }

        public ActionResult SanPhamNew()
        {
            return View(from sp in data.SANPHAMs orderby sp.MaSP descending select sp);
        }

        public ActionResult SptheoHang(string id)
        {
            return View(from sp in data.SANPHAMs where sp.MaSX==id select sp);
        }

        public ActionResult Detail(int id)
        {
            return View((from sp in data.SANPHAMs where sp.MaSP == id select sp).Single());
        }

    }
}