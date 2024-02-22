using School.DataBase;
using School.Models;
using School.Utils.Abstracts.Repositories;
using School.Utils.Abstracts.Services;

namespace School.Services;

public class SubjectService : ISubjectService
{
	private SchoolDbContext _context;
	private ISqlRepository _repository;

	public SubjectService(SchoolDbContext dbContext, ISqlRepository sqlRepository)
	{
		_context = dbContext;
		_repository = sqlRepository;
	}

    public bool Create(Subject obj)
    {
        return _repository.Create(obj);
    }

    public bool Delete(Guid id)
    {
        return _repository.Delete(id);
    }

    public ICollection<Subject> GetAll()
    {
        return _repository.GetAll();
    }

    public Subject GetById(Guid id)
    {
		return _repository.GetById(id);
    }

    public bool Update(Guid id, Subject obj)
    {
        return _repository.Update(id, obj);
    }
}