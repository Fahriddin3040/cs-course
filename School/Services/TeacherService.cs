using School.DataBase;
using School.Models;
using School.Utils.Abstracts.Repositories;
using School.Utils.Abstracts.Services;

namespace School.Services;

public class TeacherService : ITeacherService
{
	private SchoolDbContext _context;
	private ISqlRepository _repository;

	public TeacherService(SchoolDbContext dbContext, ISqlRepository sqlRepository)
	{
		_context = dbContext;
		_repository = sqlRepository;
	}

    public Teacher Create(Teacher obj)
    {
        _repository.Create(obj);
        _repository.SaveChanges();
    }

    public bool Delete(Guid id)
    {
       return  _repository.Delete(id);
    }

    public ICollection<Teacher> GetAll()
    {
        return _repository.GetAll();
    }

    public Teacher GetById(Guid id)
    {
		return _repository.GetById(id);
    }

    public bool Update(Guid id, Teacher obj)
    {
        return _repository.Update(id, obj);
    }
}