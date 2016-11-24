
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            string json = "[{\"name\":\"57430.jpg\",\"type\":\"译文\"}]";
            List<dynamic> lit = JsonConvert.DeserializeObject<List<dynamic>>(json);
            return View();
        }
    }
}