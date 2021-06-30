using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Template.Data;

namespace Template.Controllers
{
    public class ExpertsController : Controller
    {
		private readonly BlogDbContext _blogDbContext;
		public ExpertsController()
		{
			_blogDbContext = new BlogDbContext();
		}
        // GET: Experts
        public PartialViewResult AllExperts()
        {
			var experts = _blogDbContext.Experts.ToList();
            return PartialView(experts);
        }
    }
}