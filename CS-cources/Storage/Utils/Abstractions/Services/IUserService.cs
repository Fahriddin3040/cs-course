using Storage.Models;

namespace Storage.Utils.Abstractions.Services
{
    public interface IUserService
    {
        IEnumerable<User> GetAll();
        User GetById(Guid id);
        string Create(User worker);
        string Update(Guid id, User item);
        string Delete(Guid id);
        bool IsAuthentificationIser(string login, string password);
    }
}
