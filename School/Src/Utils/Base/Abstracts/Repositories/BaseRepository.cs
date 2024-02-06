namespace School.Utils.Abstracts.Repositories;

public interface IBaseRepository<T>
{
	public ICollection<T> GetAll();
	public T GetById(Guid id);
	public T Create(T obj);
}