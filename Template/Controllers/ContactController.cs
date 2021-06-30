using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Template.Data;

namespace Template.Controllers
{
    public class ContactController : Controller
    {
		// GET: Contact
		private readonly BlogDbContext _blogDbContext;
		public ContactController()
		{
			_blogDbContext = new BlogDbContext();
		}
		// GET: Experts
		public PartialViewResult AllContact()
		{
			var contacts = _blogDbContext.Contacts.ToList();
			return PartialView(contacts);
		}
	}
}