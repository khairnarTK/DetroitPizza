using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;

namespace DetroitPizza
{
   public class BlogPostDbContext : DbContext
   {
      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
      {
	      optionsBuilder.UseSqlite("Data Source=./App_Data/BlogPostdb.db");
	      optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information);
	      base.OnConfiguring(optionsBuilder);
      }

      public DbSet<BlogPost> Posts { get; set;}
      public DbSet<Tag> Tags { get; set; } 
   } 
}