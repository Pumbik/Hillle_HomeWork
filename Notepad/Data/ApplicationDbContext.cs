using Notepad.Models;
using Microsoft.EntityFrameworkCore;

namespace Notepad.Data
{
	public class ApplicationDbContext: DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{
		}

		public DbSet<Notepad> Notepads { get; set; }
	}
}
