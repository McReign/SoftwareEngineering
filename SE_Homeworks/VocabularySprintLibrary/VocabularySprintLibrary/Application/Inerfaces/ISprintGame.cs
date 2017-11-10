

using VocabularySprintLibrary.Domain.Interfaces;

namespace VocabularySprintLibrary.Application
{
    public interface ISprintGame
    {
        void StartGame();
        void FinishGame();

        IUserRepository userRepository { get; }
        string NameOfPlayer { get; }
        IUser currentUser { get; }
        IVocabularyService vocabularyService { get; set; }
        IUserService userService { get; set; }
    }
}
