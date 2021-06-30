using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Template.Data;

namespace Template.Controllers
{
    public class CarsController : Controller
    {
		// GET: Cars
		private readonly BlogDbContext _blogDbContext;
		public CarsController()
		{
			_blogDbContext = new BlogDbContext();
		}
		// GET: Experts
		public PartialViewResult AllCars()
		{
			var cars = _blogDbContext.Cars.ToList();
			return PartialView(cars);
		}
	}
}