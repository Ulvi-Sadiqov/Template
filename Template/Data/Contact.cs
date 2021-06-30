using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Template.Data
{
	public class Contact
	{
		public int Id { get; set; }

		[Required]
		public string NameOfPlace { get; set; }
		[Required]
		public string Description { get; set; }
		[Required]
		public string PhoneNumber { get; set; }
	}
 }