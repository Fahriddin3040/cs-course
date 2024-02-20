using Microsoft.EntityFrameworkCore;
using School.DataBase;
using School.Models;
using School.Utils.Abstracts.Repositories;

namespace School.Repositories;

public class GroupRepository : IGroupRepository
{
	private SchoolDbContext _context { get; set; }
	
	public GroupRepository(SchoolDbContext dbContext)
	{
		this._context = dbContext;
	}
	public ICollection<Group> GetAll()
	{
		return _context.Groups.ToList();
	}
	public Group GetById(Guid id)
	{
		return _context.Groups.First(t => t.Id == id);
	}
	public Group Create(Group obj)
	{
		_context.Groups.Add(obj);
		_context.SaveChanges();

		return obj;
	}
	public Group Update(Guid id, Group obj)
	{
		throw new NotImplementedException();
	}
	public void Delete(Guid id)
	{
		Group GroupToDelete = _context.Groups.First(t => t.Id == id);
		_context.Groups.Remove(GroupToDelete);

		_context.SaveChanges();
	}
}
