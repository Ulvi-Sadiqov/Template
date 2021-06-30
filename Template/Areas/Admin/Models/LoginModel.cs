using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Template.Areas.Admin.Models
{
	public class LoginModel
	{
		[Required]
		[EmailAddress]
		public string Email { get; set; }
		[Required]
		[DataType(DataType.Password)]
		[StringLength(maximumLength:30,MinimumLength =8)]
		public string Password { get; set; }
	}
}