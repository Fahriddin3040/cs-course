using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.VisualBasic;
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
	public SchoolDbContext()
	{
		Database.EnsureCreated();
	}
	
	static SchoolDbContext()
    {
        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
	optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=school_db;Username=school_admin;password=0089");
	
        base.OnConfiguring(optionsBuilder);
    }

    protected override  void OnModelCreating(ModelBuilder modelBuilder)
    {
		ConfigureTeacher(modelBuilder);
		ConfigureStudent(modelBuilder);
		ConfigureTrustee(modelBuilder);
		ConfigureGroup(modelBuilder);
		ConfigureSubject(modelBuilder);
		ConfigureTeachersSubjects(modelBuilder);

        base.OnModelCreating(modelBuilder);
    }

    protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
    {
        base.ConfigureConventions(configurationBuilder);
    }
	private void ConfigureTeacher(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<Teacher>( e =>
		{
			e.HasKey(e => e.Id);

			e.HasOne(e => e.Group)
				.WithOne(g => g.Curator)
				.HasForeignKey<Teacher>(e => e.GroupId);

			e.Property(e => e.GroupId)
				.IsRequired(required: false);

			e.Property(e => e.Address)
				.IsRequired(required: false);

			e.Property(e => e.Email)
				.IsRequired(required: false);

			e.Property(e => e.CreatedAt)
				.HasDefaultValue(value: DateTime.Now);

			e.Property(e => e.UpdatedAt)
				.IsRequired(required: false)
				.HasDefaultValue(value: DateTime.Now);
		});
	}
	private void ConfigureStudent(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<Student>(e =>
		{
			e.HasKey(e => e.Id);

			e.HasOne(e => e.Group)
				.WithMany(g => g.Students)
				.HasForeignKey(e => e.GroupId);
			
			e.HasOne(e => e.Trustee)
				.WithMany(t => t.Students)
				.HasForeignKey(e => e.TrusteeId);

			e.Property(e => e.Address)
				.IsRequired(required: false);

			e.Property(e => e.Email)
				.IsRequired(required: false);

			e.Property(e => e.CreatedAt)
				.HasDefaultValue(value: DateTime.Now);

			e.Property(e => e.UpdatedAt)
				.IsRequired(required: false);
		});
	}
	private void ConfigureTrustee(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<Trustee>(e => 
		{
			e.HasKey(e => e.Id);

			e.Property(e => e.Address)
				.IsRequired(required: false);

			e.Property(e => e.Email)
				.IsRequired(required: false);

			e.Property(e => e.CreatedAt)
				.HasDefaultValue(value: DateTime.Now);

			e.Property(e => e.UpdatedAt)
				.IsRequired(required: false);
		});
	}

	private void ConfigureGroup(ModelBuilder modelBuilder) =>
		modelBuilder.Entity<Group>(e => e.HasKey(e => e.Id));

	private void ConfigureSubject(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<Subject>(e =>
		{
			e.HasKey(e => e.Id);

			e.Property(e => e.Title)
				.IsRequired(required: false);
			e.Property(e => e.HomeTask)
				.IsRequired(required: false);
		});
	}

	private void ConfigureTeachersSubjects(ModelBuilder modelBuilder)
	{
    modelBuilder.Entity<TeachersSubjects>(e =>
    {
        e.HasKey(ts => new { ts.TeacherId, ts.SubjectId }); // Composite key

        e.HasOne(ts => ts.Teacher)
            .WithMany(t => t.Subjects)
            .HasForeignKey(ts => ts.TeacherId);

        e.HasOne(ts => ts.Subject)
            .WithMany(s => s.Teachers)
            .HasForeignKey(ts => ts.SubjectId);
	});
}
}
