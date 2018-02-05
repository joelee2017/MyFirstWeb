using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstWeb.Controllers
{
    public class HomeController : Controller
    {
        string SessionKey = "SessinoKey";
        string cacheKey = "cacheKey";
        string CookieName = "CookieName";
        string CookieKey = "CookieKey";

        public ActionResult Index()
        {
            Session[SessionKey] = "SessinoKey";
            System.Web.HttpContext.Current.Cache[cacheKey] = "CacheValue";//System.Web.HttpContext 
            HttpCookie c = new HttpCookie(CookieName);
            c.Values.Add(CookieKey, "CookieValue");
            c.Expires = DateTime.Now.AddDays(1); //Cookie保留一天
            Response.Cookies.Add(c);//回應到Response之中

            return View();
        }

        public ActionResult About()
        {
            string SeesionValue = Convert.ToString(Session[SessionKey]);//轉型
            string cacheValue = Convert.ToString(System.Web.HttpContext.Current.Cache[cacheKey]);
            HttpCookie c = Request.Cookies[CookieName];
            string CookieValue = Convert.ToString(c.Values[CookieKey]);

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}