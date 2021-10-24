namespace DIP.withDIP
{
    public class UserService
    {
        private IUserRepository _userRepository;
        
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
    }
}