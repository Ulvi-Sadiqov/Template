namespace Template.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
	using Template.Data;

	internal sealed class Configuration : DbMigrationsConfiguration<Template.Data.BlogDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Template.Data.BlogDbContext context)
        {
			//  This method will be called after migrating to the latest version.

			//  You can use the DbSet<T>.AddOrUpdate() helper extension method
			//  to avoid creating duplicate seed data.

			context.Experts.AddOrUpdate(new Expert
			{
				Id = 1,
				Image = "team-1.jpg",
				Username = "John Smith",
				Job = "Marketing"
			}, new Expert
			{
				Id = 2,
				Image = "team-2.jpg",
				Username = "Christine Wise",
				Job = "C.E.O"
			}, new Expert
			{
				Id = 3,
				Image = "team-3.jpg",
				Username = "Sean Robbins",
				Job = "Manager"
			}, new Expert
			{
				Id = 4,
				Image = "team-4.jpg",
				Username = "Lucy Myers",
				Job = "Delivary"
			});


			context.Offers.AddOrUpdate(new Offer {
				Id = 1,
				Name = "Rental a Cars",
				Description = "Consectetur adipiscing elit incididunt ut labore et dolore magna aliqua. Risus commodo viverra maecenas.",
				ImagePath = "services-1.png"
			}, new Offer
			{
				Id = 2,
				Name = "Buying Cars",
				Description = "Consectetur adipiscing elit incididunt ut labore et dolore magna aliqua. Risus commodo viverra maecenas.",
				ImagePath = "services-2.png"
			}, new Offer
			{
				Id = 3,
				Name = "Car Maintenance",
				Description = "Consectetur adipiscing elit incididunt ut labore et dolore magna aliqua. Risus commodo viverra maecenas.",
				ImagePath = "services-3.png"
			}, new Offer
			{
				Id = 4,
				Name = "Support 24/7",
				Description = "Consectetur adipiscing elit incididunt ut labore et dolore magna aliqua. Risus commodo viverra maecenas.",
				ImagePath = "services-4.png"
			});

			context.Contacts.AddOrUpdate(new Contact
			{
				Id = 1,
				NameOfPlace = "California Showroom",
				Description = "625 Gloria Union, California, United Stated Colorlib.california@gmail.com",
				PhoneNumber = "(+12) 456 678 9100"
			}, new Contact
			{
				Id = 2,
				NameOfPlace = "New York Showroom",
				Description = "8235 South Ave. Jamestown, NewYork Colorlib.Newyork@gmail.com",
				PhoneNumber = "(+12) 456 678 9100"
			}, new Contact
			{
				Id = 3,
				NameOfPlace = "Florida Showroom",
				Description = "497 Beaver Ridge St. Daytona Beach, Florida Colorlib.california@gmail.com",
				PhoneNumber = "(+12) 456 678 9100"
			});

			context.AboutUs.AddOrUpdate(new PersonSayAboutUs
			{
				Id = 1,
				Username = "John Smith",
				Job = "CEO Colorlib",
				Text = "For one thing they usually step all over the hedges and plants on the side of someone’shouse killing"
			    , Image = "testimonial-1.png"
			}, new PersonSayAboutUs
			{
				Id = 2,
				Username = "Emma Sandoval"
				, Job = "Marketing Manager",
				Text = "it seems though that some of the biggest problems with the internet adversiting trends are lack of",
				Image = "testimonial-2.png"
				
			
			}, new PersonSayAboutUs
			{
				Id = 3,
				Username = "John Smith",
				Job = "CEO Colorlib",
				Text = "For one thing they usually step all over the hedges and plants on the side of someone’shouse killing"
				,
				Image = "testimonial-1.png"
			}, new PersonSayAboutUs
			{
				Id = 3,
				Username = "Emma Sandoval"
				,
				Job = "Marketing Manager",
				Text = "it seems though that some of the biggest problems with the internet adversiting trends are lack of",
				Image = "testimonial-2.png"
			});

			context.Clients.AddOrUpdate(new Client
			{
				Id= 1,
				Name= "Emotion in Emotion",
				ImagePath = "client-1.png"
			}, new Client
			{
				Id = 2,
				Name = "Eaters",
				ImagePath = "client-2.png"
			}, new Client
			{
				Id = 3,
				Name = "FotoGraft",
				ImagePath = "client-3.png"
			}, new Client
			{
				Id = 4,
				Name = "Emotion in Emotion",
				ImagePath = "client-2.png"
			}, new Client
			{
				Id = 5,
				Name = "Pencl",
				ImagePath = "client-4.png"
			}, new Client
			{
				Id = 6,
				Name = "Good Food",
				ImagePath = "client-5.png"
			}, new Client
			{
				Id = 7,
				Name = "Envato",
				ImagePath = "client-6.png"
			}, new Client
			{
				Id = 8,
				Name = "Emotion in Emotion",
				ImagePath = "client-7.png"
			});

			context.News.AddOrUpdate(new News
			{
				Id=1,
				UploadTime = DateTime.Now,
				Title = "Benjamin Franklin S Method Of Habit Formation",
				Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Risus commodo viverra maecenas accumsan lacus vel facilisis.",
				IsLast = true,
				Writer = "Polly Williams",
				Viewer = 40,
				ImagePath = "lb-1.jpg"
			}, new News
			{
				Id = 2,
				UploadTime = DateTime.Now,
				Title = "How To Set Intentions That Energize You",
				Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Risus commodo viverra maecenas accumsan lacus vel facilisis.",
				IsLast = true,
				Writer = "Mattie Ramirez",
				Viewer = 40,
				ImagePath = "lb-2.jpg"
			}, new News
			{
				Id = 3,
				UploadTime = DateTime.Now,
				Title = "Burning Desire Golden Key Or Red Herring",
				Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Risus commodo viverra maecenas accumsan lacus vel facilisis.",
				IsLast = true,
				Writer = "Nicholas Brewer",
				Viewer = 40,
				ImagePath = "lb-3.jpg"
			}, new News
			{
				Id = 4,
				UploadTime = DateTime.Now,
				Title = "Benjamin Franklin S Method Of",
				Description = "Great business ideas when utilized effectively can save lots of money. This is not only easy for those who work full-time as an advertiser...",
				IsLast = false,
				Writer = "Polly Williams",
				Viewer = 40,
				ImagePath = "blog-1.jpg"
			}, new News
			{
				Id = 5,
				UploadTime = DateTime.Now,
				Title = "Where To Look For Cheap Brochure",
				Description = "Usually potential customers will visit home for business dealing. Print good amount of fliers and give it to anyone who is visiting home like family..",
				IsLast = false,
				Writer = "Evelyn Lane",
				Viewer = 40,
				ImagePath = "blog-2.jpg"
			}, new News
			{
				Id = 6,
				UploadTime = DateTime.Now,
				Title = "Promotional Advertising Specialty",
				Description = "For those who work outside home, employ college students to distribute fliers at supermarkets, community centers...",
				IsLast = false,
				Writer = "Jessie Palmer",
				Viewer = 40,
				ImagePath = "blog-3.jpg"
			}, new News
			{
				Id = 7,
				UploadTime = DateTime.Now,
				Title = "Promotional Advertising Specialty",
				Description = "Using Banner Stands To Increase",
				IsLast = false,
				Writer = "Don Townsend",
				Viewer = 40,
				ImagePath = "blog-4.jpg"
			}, new News
			{
				Id = 8,
				UploadTime = DateTime.Now,
				Title = "3 Smart Reasons Why You Should",
				Description = "It’s a very powerful tool to increase the network and doesn’t even cost anything. When receiving a casual call from family members and friends...",
				IsLast = false,
				Writer = "Isabella Mann",
				Viewer = 40,
				ImagePath = "blog-5.jpg"
			}, new News
			{
				Id = 9,
				UploadTime = DateTime.Now,
				Title = "Search Engine Optimization And",
				Description = "Some businesses place a jar at the reception counter where the business cards can be dropped for future reference, while visiting them...",
				IsLast = false,
				Writer = "Polly Williams",
				Viewer = 40,
				ImagePath = "blog-6.jpg"
			});

			context.Cars.AddOrUpdate(new Car {
				Id = 1,
				Description = "this car is best car",
				Name = "Porche cayenne turbo s",
				Mi = 35000,
				Year = 2016,
				MaxSpeed = 324,
				isAuto = true , 
				Seller = "Jack Syntom",
				HorsePower = 700,
				forMonth = true,
				Price =	218,
				Image1 = "car-1.jpg",
				Image2 = "car-8.jpg",
				Image3 = "car-6.jpg",
				Image4 = "car-3.png"
			}, new Car
			{
				Id = 2,
				Description = "this car is best car",
				Name = "Toyota Camry asv50l-jeteku",
				Mi = 35000,
				Year = 2020,
				MaxSpeed = 324,
				isAuto = true,
				Seller = "Jack Syntom",
				HorsePower = 700,
				forMonth = false,
				Price = 73900,
				Image1 = "car-2.jpg",
				Image2 = "car-8.jpg",
				Image3 = "car-6.jpg",
				Image4 = "car-4.png"
			}, new Car
			{
				Id = 3,
				Description = "this car is best car",
				Name = "Bmw s1000rr 2019 m",
				Mi = 35000,
				Year = 2017,
				MaxSpeed = 324,
				isAuto = true,
				Seller = "Jack Syntom",
				HorsePower = 700,
				forMonth = true,
				Price = 299,
				Image1 = "car-3.jpg",
				Image2 = "car-8.jpg",
				Image3 = "car-6.jpg",
				Image4 = "car-5.png"
			}, new Car
			{
				Id = 4,
				Description = "this car is best car",
				Name = "Audi q8 2020",
				Mi = 35000,
				Year = 2018,
				MaxSpeed = 324,
				isAuto = true,
				Seller = "Jack Syntom",
				HorsePower = 700,
				forMonth = true,
				Price = 319,
				Image1 = "car-5.jpg",
				Image2 = "car-8.jpg",
				Image3 = "car-7.jpg",
				Image4 = "car-2.png"
			}, new Car
			{
				Id = 5,
				Description = "this car is best car",
				Name = "Mustang shelby gt500",
				Mi = 35000,
				Year = 2016,
				MaxSpeed = 324,
				isAuto = true,
				Seller = "Jack Syntom",
				HorsePower = 700,
				forMonth = false,
				Price = 730900,
				Image1 = "car-6.jpg",
				Image2 = "car-8.jpg",
				Image3 = "car-3.jpg",
				Image4 = "car-1.png"
			}, new Car
			{
				Id = 6,
				Description = "this car is best car",
				Name = "Lamborjini huracan evo",
				Mi = 35000,
				Year = 2019,
				MaxSpeed = 324,
				isAuto = true,
				Seller = "Jack Syntom",
				HorsePower = 700,
				forMonth = true,
				Price = 319,
				Image1 = "car-4.jpg",
				Image2 = "car-8.jpg",
				Image3 = "car-2.jpg",
				Image4 = "car-1.png"
			}, new Car
			{
				Id = 7,
				Description = "this car is best car",
				Name = "Lamborjini Huracon evo",
				Mi = 35000,
				Year = 2020,
				MaxSpeed = 324,
				isAuto = true,
				Seller = "Jack Syntom",
				HorsePower = 700,
				forMonth = false,
				Price = 12000,
				Image1 = "car-7.jpg",
				Image2 = "car-2.jpg",
				Image3 = "car-4.jpg",
				Image4 = "car-1.png"
			}, new Car
			{
				Id = 8,
				Description = "this car is best car",
				Name = "Porche Cayenne turbo s",
				Mi = 35000,
				Year = 2017,
				MaxSpeed = 324,
				isAuto = true,
				Seller = "Jack Syntom",
				HorsePower = 700,
				forMonth = true,
				Price = 319,
				Image1 = "car-8.jpg",
				Image2 = "car-3.jpg",
				Image3 = "car-5.jpg",
				Image4 = "car-2.png"
			}, new Car
			{
				Id = 9,
				Description = "this car is best car",
				Name = "Toyato Camry asv50I-jetuku",
				Mi = 35000,
				Year = 2017,
				MaxSpeed = 324,
				isAuto = true,
				Seller = "Jack Syntom",
				HorsePower = 700,
				forMonth = false,
				Price = 73900,
				Image1 = "car-8.jpg",
				Image2 = "car-3.jpg",
				Image3 = "car-5.jpg",
				Image4 = "car-2.png"
			});

			context.AppUsers.AddOrUpdate(new AppUser
			{
              Id=1,
			  Name = "Admin",
			  Surname = "admin",
			  Email = "admin@gmail.com",
			  Password = "admin123"
			});
		}
    }
}
