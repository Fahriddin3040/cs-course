namespace School.Utils.Abstracts.Repositories;

public interface ISqlRepository<T>
{
	ICollection<T> GetAll();
	T GetById(Guid id);
	T Create(T obj);
	T Update(T obj);
	void Delete(Guid id);
}