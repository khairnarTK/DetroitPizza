using System.Collections.Generic;
using DetroitPizza.Models;

namespace DetroitPizza
{
	public class Tag : BaseEntity
	{
		public string Name { get; set; }
		public IList<BlogPost> BlogPosts { get; set; } = new List<BlogPost>();
	}
}