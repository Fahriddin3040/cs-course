namespace School.Configuration;
using System.Text.Json.Serialization;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using School.DataBase;
using School.Mapper;
using School.Models;
using School.Repositories;
using School.Services;
using School.Utils.Abstracts.Repositories;
using School.Utils.Base;


public class Configuration
{
	public void ConfigureServices(IServiceCollection services)
	{

		services.AddControllersWithViews();
		services.AddEndpointsApiExplorer();
		services.AddSwaggerGen();

		services.AddLogging(log =>
		{
			log.AddConsole();
		});

		services.AddControllers()
			.AddJsonOptions(options => options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
		services.AddDbContext<SchoolDbContext>(con => con.UseNpgsql(
			("Host=localhost;Port=5432;Database=school_db;Username=school_admin;password=0089"))
			.LogTo(Console.Write));
		services.AddScoped(typeof(SchoolDbContext));
		services.AddScoped(typeof(ISqlRepository<>), typeof(SqlRepository<>));
		services.AddScoped(typeof(IBaseService<Teacher>), typeof(TeacherService));

	}
}