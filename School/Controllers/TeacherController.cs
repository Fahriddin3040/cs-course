using School.Services;
using School.Models;
using Microsoft.AspNetCore.Mvc;
using School.Utils.Abstracts.Services;
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
		ICollection<Teacher> teachers =  _service.GetAll();

		return Ok(teachers);
	}

	[HttpPost]
	public IActionResult Create([FromBody] Teacher newTeacher)
	{
		Teacher createdTeacher = _service.Create(newTeacher);

		return Ok(createdTeacher);
	}
}
