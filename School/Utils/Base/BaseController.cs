using School.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using School.Utils.Base;


namespace School.Controllers;

[Route("api/[controller]")]
[ApiController]
public abstract class BaseController<TEntity> : ControllerBase, IBaseController<TEntity> where TEntity : class, IBaseEntity
{
    private readonly IBaseService<TEntity> _service;
	private readonly ILogger<IBaseController<TEntity>>? _logger;

    public BaseController(IBaseService<TEntity> baseService, ILogger<BaseController<TEntity>>? logger)
    {
		_service = baseService;
		_logger = logger;
	}

	[HttpGet]
	public virtual IActionResult Get()
	{
		return Ok(_service.GetAll());
	}

	[HttpGet("{id}")]
	public virtual IActionResult Get(Guid id)
	{
		return Ok(_service.GetById(id));
	}

	[HttpPost]
	public virtual IActionResult Create([FromBody] TEntity obj)
	{
		bool isCreated = _service.Create(obj);

		TEntity createdObj = _service.GetById(obj.Id);

		if(!isCreated)
		{
			return NotFound();
		}

		return CreatedAtAction(nameof(Get), new { id = createdObj.Id});
	}

	[HttpPut("{id}")]
	public virtual IActionResult Update(Guid id, [FromBody]TEntity obj)
	{
		_service.Update(id, obj);
		TEntity updatedObj = _service.GetById(id);

		return Ok(updatedObj);
	}

	[HttpDelete("{id}")]
	[ProducesResponseType((int)HttpStatusCode.NoContent)]
	public virtual IActionResult Delete(Guid id)
	{
		bool isDeleted = _service.Delete(id);

		if(!isDeleted)
		{
			throw new Exception("Deleting exception");
		}

		return NoContent();
	}
}
