using School.DataBase;
using School.Models;
using School.Utils.Abstracts.Repositories;
using School.Utils.Abstracts.Services;
using School.Utils.Base;

namespace School.Services;

public class TrusteeService : IBaseService<Trustee>
{
	private ISqlRepository<Trustee> _repository;

	public TrusteeService(ISqlRepository<Trustee> trusteeRepository)
	{
		_repository = trusteeRepository;
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