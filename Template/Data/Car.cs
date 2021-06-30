using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Template.Data
{
	public class Car
	{
		public int Id { get; set; }

		[Required]
		public string Seller { get; set; }

		[Required]
		public bool forMonth { get; set; }

		[Required]
		public string Description { get; set; }

		[Required]
		[StringLength(maximumLength:60 , MinimumLength =2)]
		public string Name { get; set; }

		public int MaxSpeed { get; set; }
		[Required]
		public int Year { get; set; }

		[Required]
		public bool isAuto { get; set; }

		[Required]
		public decimal Mi { get; set; }

		[Required]
		public int HorsePower { get; set; }

		[Required]
		public decimal Price { get; set; }

		[Required]
		public string Image1 {get;set;}

		[Required]
		public string Image2 { get; set; }

		[Required]
		public string Image3 { get; set; }

		[Required]
		public string Image4 { get; set; }
	}
}