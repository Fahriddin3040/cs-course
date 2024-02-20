using Microsoft.EntityFrameworkCore;
using School.DataBase;
using School.Models;
using School.Utils.Abstracts.Repositories;

namespace School.Repositories;

public class SubjectRepository : ISubjectRepository
{
	private SchoolDbContext _context { get; set; }
	
	public SubjectRepository(SchoolDbContext dbContext)
	{
		this._context = dbContext;
	}
	public ICollection<Subject> GetAll()
	{
		return _context.Subjects.ToList();
	}
	public Subject GetById(Guid id)
	{
		return _context.Subjects.First(t => t.Id == id);
	}
	public Subject Create(Subject obj)
	{
		_context.Subjects.Add(obj);
		_context.SaveChanges();

		return obj;

	}
	public Subject Update(Guid id, Subject obj)
	{
		throw new NotImplementedException();
	}
	public void Delete(Guid id)
	{
		Subject SubjectToDelete = _context.Subjects.First(t => t.Id == id);
		_context.Subjects.Remove(SubjectToDelete);

		_context.SaveChanges();
	}
}
