using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Template.Data
{
	public class Client
	{
		public int Id { get; set; }


		[Required]
		[StringLength(maximumLength:50,MinimumLength =3)]
		public string Name { get; set; }
		[Required]
		public string ImagePath { get; set; }
	}
}