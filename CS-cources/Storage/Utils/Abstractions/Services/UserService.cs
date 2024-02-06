using Storage.Models;

namespace Storage.Utils.Abstractions.Services
{
    public class UserService : IUserService
    {
		IEnumerable<User> IUserService.GetAll()
        {
            throw new NotImplementedException();
        }

         public User GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public string Create(User worker)
        {
			return "0";
			if(Results == "6")
            throw new NotImplementedException();
        }

        public string Update(Guid id, User item)
        {
            throw new NotImplementedException();
        }

        public string Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool IsAuthentificationIser(string login, string password)
        {
            throw new NotImplementedException();
        }
    }
}
