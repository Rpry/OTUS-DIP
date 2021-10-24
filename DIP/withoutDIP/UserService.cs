namespace DIP.withoutDIP
{
    public class UserService
    {
        private UserRepository _userRepository;
        
        public UserService()
        {
            _userRepository = new UserRepository();
        }
    }
}