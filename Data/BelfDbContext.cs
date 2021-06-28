using Microsoft.EntityFrameworkCore;

public class BelfDbContext : DbContext
{
	public BelfDbContext(DbContextOptions<BelfDbContext> options) : base(options) { }
	public DbSet<User2> User2 { get; set; }
}