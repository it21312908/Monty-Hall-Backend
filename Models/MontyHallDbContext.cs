using Microsoft.EntityFrameworkCore;

namespace test_backend.Models
{
	public class MontyHallDbContext : DbContext
	{
		public MontyHallDbContext(DbContextOptions options) : base(options)
		{
		}

		public DbSet<MontyHallGameResult> MontyHall { get; set; }
	}
}
