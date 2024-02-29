using School.Repositories;
using School.Utils.Abstracts.Repositories;

namespace School.Utils.Base;

public abstract class BaseService<T> : IBaseService<T> where T : class, IBaseEntity
{
	private readonly ISqlRepository<T> _repository;

	public BaseService(ISqlRepository<T> sqlRepository)
	{
		_repository = sqlRepository;
	}
	public IQueryable<T> GetAll()
	{
		return _repository.GetAll();
	}
	public T GetById(Guid id)
	{
		return _repository.GetById(id);
	}
	public bool Create(T obj)
	{
		return _repository.Create(obj);
	}
	public bool Update(Guid id, T updatedObj)
	{
		return _repository.Update(id, updatedObj);
	}
	public bool Delete(Guid id)
	{
		return _repository.Delete(id);
	}
	public bool Save()
	{
		return _repository.Save();
	}
}