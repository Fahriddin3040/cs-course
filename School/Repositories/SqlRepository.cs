using System.Runtime;
using Microsoft.EntityFrameworkCore.Storage;
using School.DataBase;
using School.Utils.Abstracts.Repositories;
using School.Utils.Base;

namespace School.Repositories;

public class SqlRepository<T> : ISqlRepository<T> where T : class, IBaseEntity
{
	private readonly SchoolDbContext _context;
	
	private bool Disposed = false; 
	
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
	public bool Create(T obj)
	{
		_context.Add(obj);

		return this.Save();
	}
	public bool Update(Guid id, T obj)
	{
		var existing_obj = _context.Set<T>().SingleOrDefault(e => e.Id == obj.Id);

		if(existing_obj == null)
		{
			return false;
		}

		_context.Entry(existing_obj).CurrentValues.SetValues(obj);

		return this.Save();
	}
	public bool Delete(Guid id)
	{
		var obj = _context.Set<T>().Find(id);

		if(obj == null)
		{
			return false;
		}	

		_context.Remove(obj);

		return this.Save();
	}
	
	public bool Save()
	{
		return _context.SaveChanges() > 0;
	}
	protected virtual void Dispose(bool disposing)
	{
		if(!this.Disposed)
		{
			if(disposing)
			{
				_context.Dispose();
			}
			this.Disposed = true;
		}
	}
	public void Dispose()
	{
		Dispose(true);
		GC.SuppressFinalize(this);
	}
	
}