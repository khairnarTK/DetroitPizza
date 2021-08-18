using System;
using System.Collections.Generic;
using DetroitPizza.Models;
using System.Linq;

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


		public override string ToString()
		{
			var tagsText = string.Empty;
			if (Tags.Any()) tagsText = $" Tagged with: [{string.Join(',', Tags.Select(t => t.Name))}]";

			return tagsText;
		}
	}
}