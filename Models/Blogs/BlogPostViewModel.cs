using System;

namespace DetroitPizza
{
   public class BlogPostViewModel
   {
      public string Title { get; set; }
      public string Content { get; set; }
      public string Tags { get; set; }
      public string Author { get; set; }
      public DateTime PublishedUTC { get; set; }

   } 
}