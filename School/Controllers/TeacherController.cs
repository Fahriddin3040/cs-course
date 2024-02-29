using School.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using School.Utils.Base;


namespace School.Controllers;

[Route("api/v1/teacher")]
[ApiController]
public class TeacherController : BaseController<Teacher>
{
	public TeacherController(IBaseService<Teacher> baseService, ILogger<TeacherController> logger) : base(baseService, logger)
	{}

	[ProducesResponseType(typeof(Teacher), (int)HttpStatusCode.OK)]
    public override IActionResult Get()
    {
        return base.Get();
    }

    [ProducesResponseType(typeof(Teacher), (int)HttpStatusCode.OK)]
    public override IActionResult Get(Guid id)
    {
        return base.Get(id);
    }

    [ProducesResponseType(typeof(Teacher), (int)HttpStatusCode.Created)]
    public override IActionResult Create([FromBody] Teacher obj)
    {
        return base.Create(obj);
    }

	[ProducesResponseType(typeof(Teacher), (int)HttpStatusCode.OK)]
	public override IActionResult Update(Guid id, [FromBody] Teacher obj)
	{
		return base.Update(id, obj);
	}

	[ProducesResponseType((int)HttpStatusCode.NoContent)]
	public override IActionResult Delete(Guid id)
	{
		return base.Delete(id);
	}

}
// [Route("api/teachers")]
// [ApiController]
// public class TeacherController : ControllerBase
// {
//     private readonly TeacherService _service;
// 	private readonly ILogger<TeacherController> _logger;

//     public TeacherController(TeacherService baseService, ILogger<TeacherController> logger)
//     {
// 		_service = baseService;
// 		_logger = logger;
// 	}

// 	[HttpGet]
// 	[ProducesResponseType(typeof(Teacher), (int)HttpStatusCode.OK)]
// 	public IActionResult Get()
// 	{
// 		return Ok(_service.GetAll());
// 	}

// 	[HttpGet("{id}")]
// 	[ProducesResponseType(typeof(Teacher), (int)HttpStatusCode.OK)]
// 	public IActionResult Get(Guid id)
// 	{
// 		return Ok(_service.GetById(id));
// 	}

// 	[HttpPost]
// 	[ProducesResponseType(typeof(Teacher), (int)HttpStatusCode.Created)]
// 	public IActionResult Create([FromBody] Teacher obj)
// 	{
// 		bool isCreated = _service.Create(obj);

// 		Teacher createdObj = _service.GetById(obj.Id);

// 		if(!isCreated)
// 		{
// 			return NotFound();
// 		}

// 		return CreatedAtAction(nameof(Get), new { id = createdObj.Id});
// 	}

// 	[HttpPut("{id}")]
// 	[ProducesResponseType(typeof(Teacher), (int)HttpStatusCode.OK)]
// 	public IActionResult Update(Guid id, [FromBody]Teacher obj)
// 	{
// 		_service.Update(id, obj);
// 		Teacher updatedObj = _service.GetById(id);

// 		return Ok(updatedObj);
// 	}

// 	[HttpDelete("{id}")]
// 	[ProducesResponseType((int)HttpStatusCode.NoContent)]
// 	public IActionResult Delete(Guid id)
// 	{
// 		bool isDeleted = _service.Delete(id);

// 		if(!isDeleted)
// 		{
// 			throw new Exception("Deleting exception");
// 		}

// 		return NoContent();
// 	}
// }
