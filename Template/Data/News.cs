using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Template.Data
{
	public class News
	{

		public int Id { get; set; }


		[Required]
	[StringLength(maximumLength:100 , MinimumLength =3)]
    public string Title { get; set; }
	[Required]
	public string Description { get; set; }
	[Required]
	public DateTime UploadTime { get; set; }
	[Required]
	public string ImagePath { get; set; }
	[Required]
	public string Writer { get; set; }
	[Required]
    public uint Viewer { get; set; }

    public bool IsLast { get; set; }
	}
}