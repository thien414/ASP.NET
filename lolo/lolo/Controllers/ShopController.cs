using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using lolo.Models;

namespace lolo.Controllers
{
    public class ShopController : Controller
    {
        dbBanDTDataContext data = new dbBanDTDataContext();

        private List<SANPHAM> laysachmoi(int sl)
        {
            return data.SANPHAMs.Take(sl).ToList();
        }

        // GET: Shop
        public ActionResult Index()
        {
            var sanpham = laysachmoi(5);
            return View(sanpham);
        }

        public ActionResult Hang()
        {
            var hang = from cd in data.NHASXes select cd;
            return View(hang);
        }

    }
}