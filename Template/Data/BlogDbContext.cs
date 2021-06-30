using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Template.Data
{
	public class BlogDbContext:DbContext
	{
		public BlogDbContext():base("myBlogDbConnection") {}

		public DbSet<Car> Cars { get; set; }
		public DbSet<Client> Clients { get; set; }
		public DbSet<Contact> Contacts { get; set; }
		public DbSet<Expert> Experts { get; set; }
		public DbSet<News> News { get; set; }
		public DbSet<Offer> Offers { get; set; }
		public DbSet<PersonSayAboutUs> AboutUs { get; set; }
		public DbSet<AppUser> AppUsers { get; set; }
	}
}