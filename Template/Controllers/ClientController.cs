using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Template.Data;

namespace Template.Controllers
{
    public class ClientController : Controller
    {
		// GET: Client
		private readonly BlogDbContext _blogDbContext;
		public ClientController()
		{
			_blogDbContext = new BlogDbContext();
		}
		// GET: Experts
		public PartialViewResult AllClient()
		{
			var clients = _blogDbContext.Clients.ToList();
			return PartialView(clients);
		}
	}
}