using School.DataBase;
using School.Models;
using School.Utils.Abstracts.Repositories;
using School.Utils.Abstracts.Services;

namespace School.Services;

public class StudentService : IStudentService
{
	private SchoolDbContext _context;
	private IStudentRepository _repository;

	public StudentService(SchoolDbContext dbContext, IStudentRepository StudentRepository)
	{
		_context = dbContext;
		_repository = StudentRepository;
	}

    public Student Create(Student obj)
    {
        return _repository.Create(obj);
    }

    public void Delete(Guid id)
    {
        _repository.Delete(id);
    }

    public ICollection<Student> GetAll()
    {
        return _repository.GetAll();
    }

    public Student GetById(Guid id)
    {
		return _repository.GetById(id);
    }

    public Student Update(Guid id, Student obj)
    {
        return _repository.Update(id, obj);
    }
}