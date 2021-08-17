using System;
using System.Collections.Generic;
using DetroitPizza.Models;

namespace DetroitPizza
{
	public class BlogPost : BaseEntity
	{
		public string Title { get; set; }
		public DateTime PublishedUtc { get; set; }
		public string Content { get; set; }
		public Author Author { get; set; }
		public int? AuthorId { get; set; }
		public IList<Tag> Tags { get; set; } = new List<Tag>();
	}
}