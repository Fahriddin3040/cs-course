namespace School.Utils.Base;

public abstract class BaseService<T> : IBaseService<T> where T : class
{
	private readonly IBaseRepository<T> _repository;

	public BaseService(IBaseRepository<T> repository)
	{
		_repository = repository;
	}
	public IEnumerable<T> GetAll()
	{
		return _repository.GetAll();
	}
	public T GetById(Guid id)
	{
		return _repository.GetById(id);
	}
	public T Update(Guid id, T updatedObj)
	{
		return _repository.Update(id, updatedObj);
	}
	public bool Delete(Guid id)
	{
		return _repository.Delete(id);
	}
}