using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DA_ASP.Models
{
    public class GioHang
    {
        dbBanDTDataContext data = new dbBanDTDataContext();
        public int iMaSP { set; get; }
        public string sTenSP { set; get; }
        public string sImgSP { set; get; }
        public Double dGiaMoi { set; get; }
        public int iSoLuong { set; get; }
        public Double dThanhTien
        {
            get { return iSoLuong * dGiaMoi; }
        }
        public GioHang(int MaSP)
        {
            iMaSP = MaSP;
            SANPHAM sp = data.SANPHAMs.Single(n => n.MaSP == iMaSP);
            sTenSP = sp.TenSP;
            sImgSP = sp.ImgSP;
            dGiaMoi = double.Parse(sp.GiaMoi.ToString());
            iSoLuong = 1;
        }

    }
}