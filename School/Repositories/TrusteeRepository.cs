using Microsoft.EntityFrameworkCore;
using School.DataBase;
using School.Models;
using School.Utils.Abstracts.Repositories;

namespace School.Repositories;

public class TrusteeRepository : ITrusteeRepository
{
	private SchoolDbContext _context { get; set; }
	
	public TrusteeRepository(SchoolDbContext dbContext)
	{
		this._context = dbContext;
	}
	public ICollection<Trustee> GetAll()
	{
		return _context.Trustees.ToList();
	}
	public Trustee GetById(Guid id)
	{
		return _context.Trustees.First(t => t.Id == id);
	}
	public Trustee Create(Trustee obj)
	{
		_context.Trustees.Add(obj);
		_context.SaveChanges();

		return obj;
	}
	public Trustee Update(Guid id, Trustee obj)
	{
		throw new NotImplementedException();
	}
	public void Delete(Guid id)
	{
		Trustee TrusteeToDelete = _context.Trustees.First(t => t.Id == id);
		_context.Trustees.Remove(TrusteeToDelete);

		_context.SaveChanges();
	}
}
