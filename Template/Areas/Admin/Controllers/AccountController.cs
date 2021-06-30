using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Template.Areas.Admin.Models;
using Template.Data;

namespace Template.Areas.Admin.Controllers
{
    public class AccountController : Controller
    {
		//private readonly BlogDbContext _blogDbContext;

		//public AccountController()
		//{
		//	_blogDbContext = new BlogDbContext();
		//}
        // GET: Admin/Account
		[HttpGet]
        public ActionResult Login()
        {
            return View();
        }
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Login(LoginModel loginModel)
		{
			if (ModelState.IsValid) {
				//AppUser appUser = _blogDbContext.AppUsers.Where(x => x.Email == loginModel.Email && x.Password == loginModel.Password).SingleOrDefault(); 


				if (loginModel.Email == "admin@gmail.com" && loginModel.Password == "admin123") {
					return RedirectToAction("Index", "Home");

				}
				else
				{
					ModelState.AddModelError("", "User and password is invalid");
					return View();
				}
			}
			return View();
		}

		public ActionResult Success()
		{
			return View();
		}
	}
}