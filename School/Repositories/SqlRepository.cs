using School.DataBase;
using School.Utils.Abstracts.Repositories;
using School.Utils.Base;

namespace School.Repositories;

public class SqlRepository<T> : ISqlRepository<T> where T : class, IBaseEntity
{
	private readonly SchoolDbContext _context;
	
	public SqlRepository(SchoolDbContext dbContext)
	{
		_context = dbContext ?? throw new ArgumentNullException();
	}
	public IQueryable<T> GetAll()
	{
		return _context.Set<T>();
	}
	public T GetById(Guid id)
	{
		return _context.Set<T>().SingleOrDefault(v => v.Id == id);
	}
	public bool Create(Guid id, T obj)
	{
		_context.Add(obj);

		var result = _context.SaveChanges();

		return result > 0;
	}
	public bool Update(T obj)
	{
		_context.Update(obj);

		var result = _context.SaveChanges();

		return result > 0;
	}
	public bool Delete(Guid id)
	{
		T obj = _context.Set<T>().SingleOrDefault(obj => obj.Id == id);
		var result =_context.SaveChanges();
		
		return result > 0;
	}
}