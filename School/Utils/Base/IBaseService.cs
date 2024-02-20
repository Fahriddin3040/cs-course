namespace School.Utils.Base;

public interface IBaseService<T> where T : class
{
	ICollection<T> GetAll();
	T GetById(Guid id);
	T Create(T obj);
	T Update(Guid id, T updatedObj);
	void Delete(Guid id);
}