using School.DataBase;
using School.Models;
using School.Utils.Abstracts.Repositories;
using School.Utils.Abstracts.Services;

namespace School.Services;

public class TrusteeService : ITrusteeService
{
	private SchoolDbContext _context;
	private IBaseRepository _repository;

	public TrusteeService(SchoolDbContext dbContext, ITrusteeRepository TrusteeRepository)
	{
		_context = dbContext;
		_repository = TrusteeRepository;
	}

    public Trustee Create(Trustee obj)
    {
        return _repository.Create(obj);
    }

    public bool Delete(Guid id)
    {
        _repository.Delete(id);
    }

    public ICollection<Trustee> GetAll()
    {
        return _repository.GetAll();
    }

    public bool GetById(Guid id)
    {
		return _repository.GetById(id);
    }

    public bool Update(Guid id, Trustee obj)
    {
        return _repository.Update(id, obj);
    }
}