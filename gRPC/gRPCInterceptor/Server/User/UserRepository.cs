
using Server.Data;

namespace Server.UserLayer
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;
        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Create(User user)
        {
            _context.Users.Add(user);
        }

        public void Delete(Guid id)
        {
            _context.Users.Remove(GetById(id));
        }

        public IQueryable<User> GetAll()
        {
            return _context.Users;
        }

        public User GetById(Guid id)
        {
            return _context.Users.SingleOrDefault(u => u.Id == id)!;
        }

        public User GetByUsername(string username)
        {
            return _context.Users.SingleOrDefault(u => u.Username == username)!;
        }

        public void Update(Guid id, User user)
        {
            _context.Users.Entry(GetById(id)).CurrentValues.SetValues(user);
        }
    }
}