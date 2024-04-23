namespace Server.UserLayer
{
    public class UserService
    {

        private readonly IUserRepository _repository;

        public UserService(IUserRepository userRepository)
        {
            _repository = userRepository;
        }

        public User NewUser(string username, string password)
        {
            return new User
            {
                Username = username,
                Password = password,
            };
        }

        public User CopyUser(User user)
        {
            return new User
            {
                Username = user.Username + "copy",
                Password = user.Password + "copy",
            };
        }

        public bool CheckPassword(string password, User user)
        {
            return password == user.Password;
        }

        public void CreateUser(User user)
        {
            _repository.Create(user);
        }

        public void DeleteUser(Guid id)
        {
            _repository.Delete(id);
        }

        public IQueryable<User> GetAllUsers()
        {
            return _repository.GetAll();
        }

        public User GetUserById(Guid id)
        {
            return _repository.GetById(id);
        }


        public User GetUserByUsername(string username)
        {
            return _repository.GetByUsername(username);
        }
    }
}