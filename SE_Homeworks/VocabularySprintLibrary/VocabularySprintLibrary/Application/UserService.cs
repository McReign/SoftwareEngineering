using System;
using System.Linq;

namespace VocabularySprintLibrary
{
    public class UserService : IUserService
    {
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public Guid RegistrationUser(string nickname)
        {
            if(!_userRepository.users.ToList().Exists(currentUser => currentUser.Nickname == nickname))
            {
                throw new InvalidOperationException();
            }

            var userId = Guid.NewGuid();
            var user = new User(userId, nickname, DateTimeOffset.UtcNow);
            _userRepository.SaveUser(user);
            return userId;
        }

        private readonly IUserRepository _userRepository;
    }
}
