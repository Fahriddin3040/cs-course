using Microsoft.AspNetCore.Mvc;

namespace School.Utils.Base;

public interface IBaseController<T> where T : class, IBaseEntity
{
	public IActionResult Get();
	public IActionResult Get(Guid id);
	public IActionResult Create(T obj);
	public IActionResult Update(Guid id, T obj);
	public IActionResult Delete(Guid id);
}