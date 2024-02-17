using Microsoft.EntityFrameworkCore;
using School.Models;
using School.Utils.Base;

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
		{
		modelBuilder.Entity<Group>()
			.HasOne(gr => gr.Curator)
			.WithOne(t => t.Group)
			.HasForeignKey<Group>(gr => gr.CuratorId);

		modelBuilder.Entity<Group>()
			.HasMany(gr => gr.Students)
			.WithOne(s => s.Group);

		modelBuilder.Entity<Group>()
			.HasMany(gr => gr.Schedules)
			.WithOne(sch => sch.Group);

		modelBuilder.Entity<Schedule>()
			.HasOne(sch => sch.Teacher)
			.WithMany(t => t.Schedules);

		modelBuilder.Entity<Schedule>()
			.HasOne(sch => sch.Subject)
			.WithMany()
			.HasForeignKey(sch => sch.Subject);

		modelBuilder.Entity<Subject>()
			.HasMany(sub => sub.Teachers)
			.WithMany(t => t.Subjects)
			.UsingEntity(j => j.ToTable("SubjectTeachers"));
	
		modelBuilder.Entity<Student>()
			.HasOne(s => s.Trustee)
			.WithMany(tr => tr.Students);

        base.OnModelCreating(modelBuilder);
    }
	}
}