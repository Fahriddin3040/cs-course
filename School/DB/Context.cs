using Microsoft.EntityFrameworkCore;
using School.Models;

namespace School.DataBase;

public class SchoolDbContext : DbContext
{
	public DbSet<Teacher> Teachers { get; set; }	
	public DbSet<Student> Students { get; set; }
	public DbSet<Trustee> Trustees { get; set; }
	public DbSet<Group> Groups { get; set; }
	public DbSet<Subject> Subjects { get; set; }
	public DbSet<Schedule> Schedules { get; set; }
	public SchoolDbContext()
	{
		Database.EnsureCreated();
	}
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Port=5433;Database=school_db;Username=school_admin;password=0089");

		base.OnConfiguring(optionsBuilder);
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
		modelBuilder.Entity<Teacher>()
			.HasMany(t => t.Subjects)
			.WithMany(sub => sub.Teachers)
			.UsingEntity(j => j.ToTable("TeacherSubjects"));

        base.OnModelCreating(modelBuilder);
    }
}