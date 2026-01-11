using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using jojo.DTO;
using jojo.Models;
using Newtonsoft.Json;

namespace jojo.Controllers
{
    public class SanPhamController : Controller
    {
        //
        // GET: /SanPham/
        jojoContext db = new jojoContext();
        public ActionResult Index()
        {
            if (Request.Cookies["nhanvien"] == null)
            {
                return Redirect("/");
            }
            NhanVienDto a = JsonConvert.DeserializeObject<NhanVienDto>(HttpUtility.UrlDecode(Request.Cookies["nhanvien"].Value));
            if (a.loai == 1)
            {
                return Redirect("/KinhDoanh");
            }
            ViewBag.nhanvien = a;

            var query = from b in db.sanphams
                        where b.active == "true"
                        select b;
            ViewBag.sanpham = query.ToList();

            var query2 = from b in db.sanphamphus
                         where b.active == "true"
                         select b;
            ViewBag.sanphamphu = query2.ToList();

            return View();
        }
	}
}