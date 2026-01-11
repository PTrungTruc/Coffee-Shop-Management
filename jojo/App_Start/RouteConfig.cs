using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace jojo
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            // Cấu hình xử lý lỗi 404 - trang không tìm thấy
            // Cấu hình route lỗi: /Error/{statusCode}
            routes.MapRoute(
                name: "Error",
                url: "Error/{statusCode}",
                defaults: new { controller = "Error", action = "HandleError" }
            );
        }
    }
}
