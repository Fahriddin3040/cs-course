using Microsoft.EntityFrameworkCore;
using School.DataBase;
using School.Models;
using School.Utils.Abstracts.Repositories;

namespace School.Repositories;

public class StudentRepository : IStudentRepository
{
	private SchoolDbContext _context { get; set; }
	
	public StudentRepository(SchoolDbContext dbContext)
	{
		this._context = dbContext;
	}
	public ICollection<Student> GetAll()
	{
		return _context.Students.ToList();
	}
	public Student GetById(Guid id)
	{
		return _context.Students.First(t => t.Id == id);
	}
	public Student Create(Student obj)
	{
		_context.Students.Add(obj);
		_context.SaveChanges();

		return obj;

	}
	public Student Update(Guid id, Student obj)
	{
		throw new NotImplementedException();
	}
	public void Delete(Guid id)
	{
		Student StudentToDelete = _context.Students.First(t => t.Id == id);
		_context.Students.Remove(StudentToDelete);

		_context.SaveChanges();
	}
}
