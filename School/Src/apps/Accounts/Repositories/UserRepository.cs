using School.Accounts.Models;
using School.Accounts.Utils.Abstracts.Repositories;

namespace School.Accounts.Repositories;

public class UserRepository : IUserRepository
{
    public ICollection<User> GetAll()
    {
        throw new NotImplementedException();
    }
	
}