namespace School.Utils.Base;

public interface IBaseService<T> where T : class
{
	IQueryable<T> GetAll();
	T GetById(Guid id);
	bool Create(T obj);
	bool Update(Guid id, T updatedObj);
	bool Delete(Guid id);
}