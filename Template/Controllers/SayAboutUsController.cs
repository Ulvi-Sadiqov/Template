using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Template.Data;

namespace Template.Controllers
{
    public class SayAboutUsController : Controller
    {
		// GET: SayAboutUs
		private readonly BlogDbContext _blogDbContext;
		public SayAboutUsController()
		{
			_blogDbContext = new BlogDbContext();
		}
		// GET: Experts
		public PartialViewResult AllComments()
		{
			var comments = _blogDbContext.AboutUs.ToList();
			return PartialView(comments);
		}
	}
}