using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Template.Data
{
	public class Expert
	{
		public int Id { get; set; }


		[Required]
		public string Image { get; set; }
		[Required]
		public string Username { get; set; }
		[Required]
		public string Job { get; set; }
	}
}