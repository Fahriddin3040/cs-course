using School.Accounts.Models;
using School.Accounts.Utils.Abstracts.Repositories;

namespace School.Accounts.Repositories;

public class UserRepository : IUserRepository
{
    public ICollection<AbstractUser> GetAll()
    {
        throw new NotImplementedException();
    }
	
}