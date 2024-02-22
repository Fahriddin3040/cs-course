namespace School.Utils.Base;

public abstract class BaseService<T> : IBaseService<T> where T : class
{
	private readonly ISqlRepository _repository;

	public BaseService(ISqlRepository sqlRepository)
	{
		_repository = sqlRepository;
	}
	public ICollection<T> GetAll()
	{
		return _repository.GetAll();
	}
	public T GetById(Guid id)
	{
		return _repository.GetById(id);
	}
	public bool Create(T obj)
	{
		return _repository.Create(obj)
	}
	public bool Update(T updatedObj)
	{
		return _repository.Update(updatedObj);
	}
	public bool Delete(Guid id)
	{
		return _repository.Delete(id);
	}
}