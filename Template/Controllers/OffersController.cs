using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Template.Data;

namespace Template.Controllers
{
    public class OffersController : Controller
    {
		private readonly BlogDbContext _blogDbContext;
		public OffersController()
		{
			_blogDbContext = new BlogDbContext();
		}
		// GET: Experts
		public PartialViewResult AllOffers()
		{
			var offers = _blogDbContext.Offers.ToList();
			return PartialView(offers);
		}
		// GET: Offers
		
    }
}