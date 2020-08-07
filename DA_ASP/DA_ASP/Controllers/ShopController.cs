using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DA_ASP.Models;

namespace DA_ASP.Controllers
{
    public class ShopController : Controller
    {
        dbBanDTDataContext data = new dbBanDTDataContext();

        private List<SANPHAM> listSP(int sl)
        {
            return data.SANPHAMs.Take(sl).ToList();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Hang()
        {
            return PartialView(from hang in data.NHASXes select hang);
        }

        public ActionResult SanPhamNew()
        {
            return View(from sp in data.SANPHAMs orderby sp.MaSP descending select sp);
        }

        public ActionResult SpFeatured()
        {
            return View(listSP(10));
        }

        public ActionResult SpHang(string id)
        {
                return View(from sp in data.SANPHAMs where sp.MaSX == id select sp);
           
        }

        public ActionResult Detail(int id)
        {
            return View((from sp in data.SANPHAMs where sp.MaSP == id select sp).Single());
        }

        public ActionResult Brand()
        {
            return PartialView(from h in data.NHASXes select h);
        }

        public ActionResult Products()
        {
            return View();
        }

        public ActionResult ProductNew()
        {
            return PartialView(from sp in data.SANPHAMs orderby sp.MaSP descending select sp);
        }

        public ActionResult Product()
        {
                return View(from sp in data.SANPHAMs select sp);
        }

        public ActionResult ProductInBrand(string id)
        {
            return PartialView(from sp in data.SANPHAMs where sp.MaSX == id select sp);
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}