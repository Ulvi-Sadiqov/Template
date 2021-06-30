using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Template.Models
{
	public class OffersIndexModel
	{
		public int Id { get; set; }

		[Required]
		[StringLength(maximumLength: 30, MinimumLength = 2)]
		public string Name { get; set; }

		[Required]
		public string Description { get; set; }

		[Required]
		public string ImagePath { get; set; }
	}
}