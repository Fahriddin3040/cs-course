using Microsoft.EntityFrameworkCore;
using School.Models;

namespace School.DataBase;

public class SchoolDbContext : DbContext
{
	public DbSet<Teacher> Users { get; set; }
	public SchoolDbContext()
	{
		Database.EnsureCreated();
	}
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Port=5433;Database=school_db;Username=school_admin;password=0089");
    }
}