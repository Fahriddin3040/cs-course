using School.Accounts.Models;

namespace School.Accounts.Utils.Abstracts.Repositories;

public interface IUserRepository
{
	public ICollection<User> GetAll();
}