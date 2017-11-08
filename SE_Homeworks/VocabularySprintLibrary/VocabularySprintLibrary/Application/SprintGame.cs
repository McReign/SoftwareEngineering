using System;
using VocabularySprintLibrary.Infrastructure;

namespace VocabularySprintLibrary.Application
{
    internal class SprintGame : ISprintGame
    {
        public SprintGame(string nameOfPlayer)
        {
            userRepository = new InMemoryUserRepository();
            NameOfPlayer = nameOfPlayer;
        }

        public void StartGame()
        {
            IUserService userService = new UserService(userRepository);

            currentUser = userRepository.LoadUser(userService.RegistrationUser(NameOfPlayer));  

            IVocabularyService vocabularyService = new VocabularyService(currentUser);
        }

        public void FinishGame()
        {
            userRepository.SaveUser(currentUser);
        }

        public IUserRepository userRepository;
        public string NameOfPlayer;
        public User currentUser;
    }
}
