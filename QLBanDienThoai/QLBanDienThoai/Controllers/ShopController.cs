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
            return View(listSP(data.SANPHAMs.Count()));
        }
    }
}