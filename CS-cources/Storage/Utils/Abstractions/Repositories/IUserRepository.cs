using System.ComponentModel;
using Storage.Models;

namespace Storage.Utils.Abstractions.Repositories;

public interface IUserRepository
{
	IEnumerable<User> GetAll();
	User GetById(Guid id); 
	bool Create(User user);
	bool Update(User item);
	bool Delete(Guid id);
}

