using Microsoft.AspNetCore.Mvc;
using School.Utils.Base;
using School.Models;
using AutoMapper;
using System.Net;
using System.Linq;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using Microsoft.EntityFrameworkCore;
using School.dto;

namespace School.Controllers;

[Route("api/students")]
[ApiController]
public class StudentController: ControllerBase
{
	private readonly IBaseService<Student> _service;
	private IMapper _mapper;

	public StudentController(
		IBaseService<Student> service, IMapper mapper
	){
		_service = service;
		_mapper = mapper;
	}


	[HttpGet]
	[ProducesResponseType(typeof(ICollection<Student>), (int)HttpStatusCode.OK)]
	public IActionResult Get() 
	{
		return Ok(_service.GetAll());
	}

	[HttpGet("{id}")]
	[ProducesResponseType(typeof(Student), (int)HttpStatusCode.OK)]
	public IActionResult Get(Guid id) 
	{
		return Ok(_service.GetById(id));
	}
	
	[HttpPost]
	[ProducesResponseType(typeof(Student), (int)HttpStatusCode.Created)]
	public IActionResult Create([FromBody] StudentCreateDTO obj)
	{
		Student newObj = _mapper.Map<Student>(obj);
		bool isCreated = _service.Create(newObj);

		if(!isCreated) 
		{
			return NotFound();
		}

		Student createdObj = _service.GetById(newObj.Id);
		
		return CreatedAtAction(nameof(Get), new { id = createdObj.Id }, createdObj);
	}

	[HttpPatch("{id}")]
	[ProducesResponseType(typeof(Student), (int)HttpStatusCode.OK)]
	public IActionResult Update(Guid id, [FromBody] StudentUpdateDTO obj)
	{
		Student existingObj = _service.GetById(id);
		Student newObj = _mapper.Map<Student>(obj);
		if (existingObj == null)
		{
			return NotFound();
		}

		_mapper.Map(obj, existingObj);

		bool isUpdated = _service.Update(id, existingObj);

		if (!isUpdated)
		{
			return NotFound();
		}

		return Ok(existingObj);
	}
	
}