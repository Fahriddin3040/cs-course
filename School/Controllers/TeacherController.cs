using School.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using School.Utils.Base;
using School.dto;
using AutoMapper;


namespace School.Controllers;

[Route("api/teachers")]
[ApiController]
public class TeacherController : ControllerBase
{
    private readonly IBaseService<Teacher> _service;
    private IMapper _mapper;

    public TeacherController(
		IBaseService<Teacher> baseService, IMapper mapper
		) {
		_service = baseService;
		_mapper = mapper;
	}

	[HttpGet]
	[ProducesResponseType(typeof(Teacher), (int)HttpStatusCode.OK)]
	public IActionResult Get()
	{
		return Ok(_service.GetAll());
	}

	[HttpGet("{id}")]
	[ProducesResponseType(typeof(Teacher), (int)HttpStatusCode.OK)]
	public IActionResult Get(Guid id)
	{
		return Ok(_service.GetById(id));
	}

	[HttpPost]
	[ProducesResponseType(typeof(Teacher), (int)HttpStatusCode.Created)]
    public IActionResult Create([FromBody] TeacherCreateDTO obj)
    {
        Teacher newObj = _mapper.Map<Teacher>(obj);

        bool isCreated = _service.Create(newObj);

		if(!isCreated)  
		{
			return NotFound();
		}

		Teacher createdObj = _service.GetById(newObj.Id);

        return CreatedAtAction(nameof(Get), new { id = createdObj.Id }, createdObj);
		
}

	[HttpPatch("{id}")]
	[ProducesResponseType(typeof(Teacher), (int)HttpStatusCode.OK)]
	public IActionResult Update(Guid id, [FromBody]Teacher obj)
	{
		bool is_updated = _service.Update(id, obj);

		if(!is_updated) {
			throw new Exception("Updating exception");
		}

		Teacher updatedObj = _service.GetById(id);

		return Ok(updatedObj);
	}

	[HttpDelete("{id}")]
	[ProducesResponseType((int)HttpStatusCode.NoContent)]
	public IActionResult Delete(Guid id)
	{
		bool isDeleted = _service.Delete(id);

		if(!isDeleted)
		{
			throw new Exception("Deleting exception");
		}

		return NoContent();
	}
}

// [Route("api/v1/teacher")]
// [ApiController]
// public class TeacherController : BaseController<Teacher>
// {
// 	public TeacherController(IBaseService<Teacher> baseService, ILogger<TeacherController> logger) : base(baseService, logger)
// 	{}

// 	[ProducesResponseType(typeof(Teacher), (int)HttpStatusCode.OK)]
//     public override IActionResult Get()
//     {
//         return base.Get();
//     }

//     [ProducesResponseType(typeof(Teacher), (int)HttpStatusCode.OK)]
//     public override IActionResult Get(Guid id)
//     {
//         return base.Get(id);
//     }

//     [HttpPost("createwithdto")]
//     [ProducesResponseType(typeof(Teacher), (int)HttpStatusCode.Created)]
//     public IActionResult CreatingMe([FromBody] TeacherCreateDTO obj)
//     {
//         Teacher newObj = new Teacher
//         {
//             Username = obj.Username,
//             FirstName = obj.FirstName,
//             LastName = obj.LastName,
//             PhoneNumber = obj.PhoneNumber,
//             Address = obj.Address,
//             Age = obj.Age,
//             Email = obj.Email,
//             GroupId = obj.GroupId
//         };

//         bool isCreated = _service.Create(newObj);

// 		if(!isCreated)
// 		{
// 			return NotFound();
// 		}

// 		Teacher createdObj = _service.GetById(newObj.Id);

// 		return CreatedAtAction(nameof(Get), new { id = createdObj.Id});

//     }

// 	[ProducesResponseType(typeof(Teacher), (int)HttpStatusCode.OK)]
// 	public override IActionResult Update(Guid id, [FromBody] Teacher obj)
// 	{
// 		return base.Update(id, obj);
// 	}

// 	[ProducesResponseType((int)HttpStatusCode.NoContent)]
// 	public override IActionResult Delete(Guid id)
// 	{
// 		return base.Delete(id);
// 	}

// }