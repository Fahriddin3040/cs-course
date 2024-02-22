using School.DataBase;
using School.Models;
using School.Utils.Abstracts.Repositories;
using School.Utils.Abstracts.Services;

namespace School.Services;

public class TeacherService : ITeacherService
{
	private SchoolDbContext _context;
	private ITeacherRepository _repository;

	public TeacherService(SchoolDbContext dbContext, ITeacherRepository teacherRepository)
	{
		_context = dbContext;
		_repository = TeacherRepository;
	}

    public Teacher Create(Teacher obj)
    {
        return _repository.Create(obj);
    }

    public void Delete(Guid id)
    {
        _repository.Delete(id);
    }

    public ICollection<Teacher> GetAll()
    {
        return _repository.GetAll();
    }

    public Teacher GetById(Guid id)
    {
		return _repository.GetById(id);
    }

    public Teacher Update(Guid id, Teacher obj)
    {
        return _repository.Update(id, obj);
    }
}