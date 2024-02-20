using School.DataBase;
using School.Models;
using School.Utils.Abstracts.Repositories;
using School.Utils.Abstracts.Services;

namespace School.Services;

public class GroupService : IGroupService
{
	private SchoolDbContext _context;
	private IGroupRepository _repository;

	public GroupService(SchoolDbContext dbContext, IGroupRepository groupRepository)
	{
		_context = dbContext;
		_repository = groupRepository;
	}

    public Group Create(Group obj)
    {
        return _repository.Create(obj);
    }

    public void Delete(Guid id)
    {
        _repository.Delete(id);
    }

    public ICollection<Group> GetAll()
    {
        return _repository.GetAll();
    }

    public Group GetById(Guid id)
    {
		return _repository.GetById(id);
    }

    public Group Update(Guid id, Group obj)
    {
        return _repository.Update(id, obj);
    }
}