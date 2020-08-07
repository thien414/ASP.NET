using DA_ASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DA_ASP.Controllers
{
    public class AcCountController : Controller
    {
        dbBanDTDataContext data = new dbBanDTDataContext();
        // GET: AcCount
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult DangKy()
        {
            return View();
        }
        //POST: ham dangky(post) nhan du lieu tu trang dang ky vaf thuc hien viec tao moi du lieu
        [HttpPost]
        public ActionResult DangKy(FormCollection collection, TKKHACHHANG kh)
        {
            var TenUser = collection["TenUser"];
            var SDTUser = collection["SDTUser"];
            var Email = collection["Email"];
            var DiaChi = collection["DiaChi"];
            var MKUser = collection["MKUser"];
            var MKUserNL = collection["MKUserNL"];
            var NgaySinh = String.Format("{0:mm/dd/yyyy}", collection["NgaySinh"]);

            if (String.IsNullOrEmpty(TenUser))
            {
                ViewData["Loi2"] = "Ten khach hang khong duoc de trong !!!";
            }
            else if (String.IsNullOrEmpty(SDTUser))
            {
                ViewData["Loi3"] = "Phai nhap so dien thoai khach hang !!!";
            }
            else if (String.IsNullOrEmpty(Email))
            {
                ViewData["Loi4"] = "Email khach hang khong duoc de trong !!!";
            }
            else if (String.IsNullOrEmpty(DiaChi))
            {
                ViewData["Loi5"] = "Phai nhap dia chi khach hang !!!";
            }
            else if (String.IsNullOrEmpty(MKUser))
            {
                ViewData["Loi6"] = "Phai nhap mat khau khach hang !!!";
            }
            else if (String.IsNullOrEmpty(MKUserNL))
            {
                ViewData["Loi7"] = "Phai nhap lai mat khau khach hang !!!";
            }
            else
            {
                //gan gia tri cho doi tuong duoc tao moi (kh)
                kh.TenUser = TenUser;
                kh.SDTUser = SDTUser;
                kh.Email = Email;
                kh.DiaChi = DiaChi;
                kh.MKUser = MKUser;
                kh.NgaySinh = NgaySinh;
                data.TKKHACHHANGs.InsertOnSubmit(kh);
                data.SubmitChanges();
                return RedirectToAction("DangNhap");
            }
            return this.DangKy();
        }

        [HttpGet]
        public ActionResult DangNhap()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DangNhap(FormCollection collection)
        {
            var SDTUser = collection["SDTUser"];
            var MKUser = collection["MKUser"];
            if (String.IsNullOrEmpty(SDTUser))
            {
                ViewData["Loi1"] = "Phai nhap so dien thoai !!!";
            }else if (String.IsNullOrEmpty(MKUser))
            {
                ViewData["Loi2"] = "Phai nhap mat khau !!!";
            }
            else
            {
                //Gan gia tri cho doi tuong duoc tao moi (kh)
                TKKHACHHANG kh = data.TKKHACHHANGs.SingleOrDefault(n => n.SDTUser == SDTUser && n.MKUser == MKUser);
                if(kh != null)
                {
                    ViewBag.Thongbao = "Dang nhap thanh cong";
                    Session["User"] = kh;
                }
                else
                {
                    ViewBag.Thongbao = "Ten dang nhap hoat mat khau khong dung";
                }
                return View();
            }
            return View();
        }
    } 
}