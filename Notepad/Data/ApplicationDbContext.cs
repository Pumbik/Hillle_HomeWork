using Notepad.Models;
using Microsoft.EntityFrameworkCore;

namespace Notepad.Data
{
	public class ApplicationDbContext: DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{
		}

		public DbSet<Notepad.Models.Notepad> Notepads { get; set; }
	}
}
