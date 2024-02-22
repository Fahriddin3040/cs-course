namespace School.Utils.Abstracts.Repositories;

public interface ISqlRepository<T>
{
	IQueryable<T> GetAll();
	T GetById(Guid id);
	bool Create(T obj);
	bool Update(T obj);
	bool Delete(Guid id);
	bool Save();
}