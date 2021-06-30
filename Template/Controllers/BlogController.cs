using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Template.Data;

namespace Template.Controllers
{
    public class BlogController : Controller
    {
		// GET: Blog
		private readonly BlogDbContext _blogDbContext;
		public BlogController()
		{
			_blogDbContext = new BlogDbContext();
		}
		public PartialViewResult AllBlogs()
		{
			var blogs = _blogDbContext.News.ToList();
			return PartialView(blogs);
		}
	}
}