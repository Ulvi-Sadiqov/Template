using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Template.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

		public ActionResult Cars()
		{
			return View();
		}

		public ActionResult Blog()
		{
			return View();
		}

		public ActionResult About()
		{
			return View();
		}

		public ActionResult carDetails()
		{
			return View();
		}

		public ActionResult blogDetails()
		{
			return View();
		}
		
		public ActionResult Contact()
		{
			return View();
		}
    }
}