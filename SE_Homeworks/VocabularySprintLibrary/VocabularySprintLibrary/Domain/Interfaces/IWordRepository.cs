
using System.Collections.Generic;
using VocabularySprintLibrary.Infrastructure;

namespace VocabularySprintLibrary.Domain
{
    internal interface IWordRepository
    {
        void AddWord(User user, Word word);
        IEnumerable<Word> LoadLearnedWords(User user);
        IEnumerable<Word> LoadUnlearnedWords(User user);

        File file { get; }
        IUserRepository _userRepository { get; }
    }
}
