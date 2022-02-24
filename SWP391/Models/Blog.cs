﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SWP391.Models
{
	[Table("Blogs")]
	public class Blog
	{
		public string BlogId { get; set; }
		public string Title { get; set; }
		public string Brief { get; set; }
		public string Content { get; set; }
		public int Featured { get; set; }
		public int ThumbnailURL { get; set; }
		public int CreatedDate { get; set; }
		public virtual Status Status { get; set; }
		public string StatusId { get; set; }
		public virtual Category Category { get; set; }
		public string CategoryId { get; set; }
		public virtual AppUser User { get; set; }
		public string UserId { get; set; }
		public ICollection<Comment> Comments { get; set; }
		
	}
}
