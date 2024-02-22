using School.Services;
using School.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace School.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TeacherController : ControllerBase
{
	private readonly TeacherService _service;

	public TeacherController(TeacherService teacherService)
	{
		_service = teacherService;
	}

	[HttpGet]
	public IActionResult GetAll()
	{
		IQueryable<Teacher> teachers = _service.GetAll();

		return Ok(teachers);
	}

	[HttpPost]
	public IActionResult Create([FromBody] Teacher newTeacher)
	{
		bool is_created = _service.Create(newTeacher);
		
		if(!is_created)
		{
			throw new Exception("Ошибка при сохранении.");
		}

		return Ok("Успешно сохранено.");
	}
}
