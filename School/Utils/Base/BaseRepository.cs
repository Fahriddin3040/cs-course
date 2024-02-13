using Microsoft.EntityFrameworkCore;
using School.DataBase;

namespace School.Utils.Base;

public abstract class BaseRepository<T> : IBaseRepository<T> where T : class
{
	private readonly SchoolDbContext _dbContext;

	public BaseRepository(SchoolDbContext schoolDbContext)
	{
		_dbContext = schoolDbContext;
	}

	public ICollection<T> GetAll()
	{
		throw new NotImplementedException();
	}
	public T GetById(Guid id)
	{
		throw new NotImplementedException();
	}
	public T Create(T obj)
	{
		throw new NotImplementedException();
	}
	public T Update(Guid id, T obj)
	{
		throw new NotImplementedException();
	}
	public bool Delete(Guid id)
	{
		throw new NotImplementedException();
	}
}