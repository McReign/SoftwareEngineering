using VocabularySprintLibrary.Domain.Interfaces;
using VocabularySprintLibrary.Infrastructure;

namespace VocabularySprintLibrary.Application
{
    public class SprintGame 
    {
        public SprintGame(string nameOfPlayer)
        {
            userRepository = new InFolderUserRepository();
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

        public IUserRepository userRepository { get; private set; }
        public string NameOfPlayer { get; }
        public IUser currentUser { get; private set; }
    }
}
