using Storage.Models;
using Storage.Utils.Abstractions.Repositories;

namespace Storage.Services;

class UserRepository: IUserRepository
{
	static Dictionary<Guid, User> Items = new Dictionary<Guid, User>();

	public IEnumerable<User> GetAll()
	{
		throw new NotImplementedException();
	}
	public User GetById(Guid id)
	{
		throw new NotImplementedException();
	}
	public bool Create(User user)
	{
		throw new NotImplementedException();
	}
	public bool Delete(Guid id)
	{
		throw new NotImplementedException();
	}
		public bool Update(User item)
	{
		throw new NotImplementedException();
	}

	
}