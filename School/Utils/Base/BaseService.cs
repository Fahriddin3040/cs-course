using School.Repositories;
using School.Utils.Abstracts.Repositories;

namespace School.Utils.Base;

public abstract class BaseService<T> : IBaseService<T> where T : class, IBaseEntity
{
	private readonly ISqlRepository<T> _repository;

	public BaseService(ISqlRepository<T> sqlRepository)
	{
		_repository = sqlRepository ?? throw new ArgumentNullException(nameof(sqlRepository));
	}
	public virtual IQueryable<T> GetAll()
	{
		return _repository.GetAll();
	}
	public virtual T GetById(Guid id)
	{
		return _repository.GetById(id);
	}
	public virtual bool Create(T obj)
	{
		return _repository.Create(obj);
	}
	public virtual bool Update(T updatedObj)
	{
		return _repository.Update(updatedObj);
	}
	public virtual bool Delete(Guid id)
	{
		return _repository.Delete(id);
	}
	public bool Save()
	{
		return _repository.Save();
	}
}