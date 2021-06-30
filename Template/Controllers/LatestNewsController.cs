using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Template.Data;

namespace Template.Controllers
{
    public class LatestNewsController : Controller
    {
		private readonly BlogDbContext _blogDbContext;
		public LatestNewsController()
		{
			_blogDbContext = new BlogDbContext();
		}
		// GET: LatestNews
		public ActionResult AllLastNews()
        {
			var news = _blogDbContext.News.ToList();

			return View(news);
		}
	}
}