namespace School.Utils.Base;

public interface IBaseService<T> where T : class
{
	ICollection<T> GetAll();
	T GetById(Guid id);
	bool Create(T obj);
	bool Update(T updatedObj);
	bool Delete(Guid id);
}