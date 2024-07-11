using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public class Kategori
        {
            public string cartNumber { get; set; }
        }
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }
}