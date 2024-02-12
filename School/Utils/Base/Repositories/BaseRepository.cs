using School.Models;

namespace School.Utils.Base.Repositories;

public interface IBaseRepository<T>
{
    ICollection<T> GetAll();
	T GetById(Guid id);
	T Create(T obj);
	T Update(Guid id, T obj);
	void Delete(Guid id);
}