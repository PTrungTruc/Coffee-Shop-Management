using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace jojo.Controllers
{
    public class ErrorController : Controller
    {
        // Action xử lý lỗi chung
        public ActionResult Index()
        {
            ViewBag.ErrorMessage = "Có lỗi xảy ra trong ứng dụng.";
            return View();
        }

        // Action xử lý lỗi HTTP
        public ActionResult HandleError(int statusCode)
        {
            // Kiểm tra nếu có aspxerrorpath, chuyển hướng lại đúng trang lỗi
            
            ViewBag.ErrorMessage = statusCode == 404 ? "Không tìm thấy trang bạn yêu cầu." : "Có sự cố xảy ra.";
            Response.StatusCode = statusCode;
            return View("Index.cshtml");
        }
    }
}