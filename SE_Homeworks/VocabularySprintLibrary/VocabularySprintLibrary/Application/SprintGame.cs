using VocabularySprintLibrary.Domain.Interfaces;
using VocabularySprintLibrary.Infrastructure;

namespace VocabularySprintLibrary.Application
{
    public class SprintGame : ISprintGame
    {
        public SprintGame(string nameOfPlayer)
        {
            userRepository = new InFolderUserRepository();
            NameOfPlayer = nameOfPlayer;
        }

        public void StartGame()
        {
            userService = new UserService(userRepository);

            currentUser = userRepository.LoadUser(userService.RegistrationUser(NameOfPlayer));  

            vocabularyService = new VocabularyService(currentUser);
        }

        public void FinishGame()
        {
            userRepository.SaveUser(currentUser);
        }

        public IUserRepository userRepository { get; set; }
        public string NameOfPlayer { get; }
        public IUser currentUser { get; set; }
        public IVocabularyService vocabularyService { get; set; }
        public IUserService userService { get; set; }
    }
}
