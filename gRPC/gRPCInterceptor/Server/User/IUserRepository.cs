namespace Server.UserLayer
{
    public interface IUserRepository
    {
        IQueryable<User> GetAll();

        User GetByUsername(string username);

        User GetById(Guid id);

        void Create(User user);

        void Update(Guid id, User user);

        void Delete(Guid id);
    }
}