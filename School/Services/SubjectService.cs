using School.DataBase;
using School.Models;
using School.Utils.Abstracts.Repositories;
using School.Utils.Abstracts.Services;

namespace School.Services;

public class SubjectService : ISubjectService
{
	private SchoolDbContext _context;
	private ISubjectRepository _repository;

	public SubjectService(SchoolDbContext dbContext, ISubjectRepository SubjectRepository)
	{
		_context = dbContext;
		_repository = SubjectRepository;
	}

    public Subject Create(Subject obj)
    {
        return _repository.Create(obj);
    }

    public void Delete(Guid id)
    {
        _repository.Delete(id);
    }

    public ICollection<Subject> GetAll()
    {
        return _repository.GetAll();
    }

    public Subject GetById(Guid id)
    {
		return _repository.GetById(id);
    }

    public Subject Update(Guid id, Subject obj)
    {
        return _repository.Update(id, obj);
    }
}