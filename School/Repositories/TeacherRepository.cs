using Microsoft.EntityFrameworkCore;
using School.DataBase;
using School.Models;
using School.Utils.Abstracts.Repositories;

namespace School.Repositories;

public class TeacherRepository : ITeacherRepository
{
	private SchoolDbContext _context { get; set; }
	
	public TeacherRepository(SchoolDbContext dbContext)
	{
		this._context = dbContext;
	}
	public ICollection<Teacher> GetAll()
	{
		return _context.Teachers.ToList();
	}
	public Teacher GetById(Guid id)
	{
		return _context.Teachers.First(t => t.Id == id);
	}
	public Teacher Create(Teacher obj)
	{
		_context.Teachers.Add(obj);
		_context.SaveChanges();

		return obj;

	}
	public Teacher Update(Guid id, Teacher obj)
	{
		throw new NotImplementedException();
	}
	public void Delete(Guid id)
	{
		Teacher teacherToDelete = _context.Teachers.First(t => t.Id == id);
		_context.Teachers.Remove(teacherToDelete);

		_context.SaveChanges();
	}
}
