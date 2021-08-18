using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DetroitPizza.Controllers
{
	[ApiController]
	[Route("/api/[controller]")]
	public class BlogController : ControllerBase
	{
	   private readonly BlogPostDbContext _db;
	   public BlogController(BlogPostDbContext db)
	   {
		   _db = db; 
	   }

	  [HttpPost]
	   public async Task<IActionResult> Create(BlogPost post)
	   {
		 await _db.AddAsync(post);
		 await _db.SaveChangesAsync();
		 return CreatedAtAction(nameof(Create), new {id = post.Id},post);
	   }

	  [HttpGet] 
	   public async Task<ActionResult<List<BlogPostViewModel>>> GetAll()
	   {
		   return await _db.Posts.AsNoTracking().
					Select(x => new BlogPostViewModel{
						Title = x.Title,
						Content = x.Content,
						Tags = $" Tagged with: [{string.Join(',', x.Tags.Select(t => t.Name))}]",
						Author = x.Author.Name
					}).ToListAsync();
	   }

	   [HttpGet("{id}")]
	   public async Task<ActionResult<BlogPostViewModel>> Get(int id)
	   {
		   var post = await _db.Posts.AsNoTracking().Where(m => m.Id == id).Select(x => new BlogPostViewModel
		   {
			   Title = x.Title,
			   Content = x.Content,
			   Tags = $" Tagged with: [{string.Join(',', x.Tags.Select(t => t.Name))}]",
			   Author = x.Author.Name
		   }).FirstOrDefaultAsync();

		   return Ok(post);
	   }
	}
}