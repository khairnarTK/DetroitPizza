using System.Collections.Generic;

namespace DetroitPizza
{
	public class Author : BaseEntity
	{
		public string Name { get; set; }
		public string TwitterUserName { get; set; }
		public IEnumerable<BlogPost> Posts { get; set;}		
	}

}