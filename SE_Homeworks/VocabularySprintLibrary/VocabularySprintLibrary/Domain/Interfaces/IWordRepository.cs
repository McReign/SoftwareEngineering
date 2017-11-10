
using System.Collections.Generic;
using VocabularySprintLibrary.Domain.Interfaces;
using VocabularySprintLibrary.Infrastructure;

namespace VocabularySprintLibrary.Domain
{
    public interface IWordRepository
    {
        void AddWord(IUser user, IWord word);
        IEnumerable<IWord> LoadLearnedWords(IUser user);
        IEnumerable<IWord> LoadUnlearnedWords(IUser user);

        File file { get; }
        IUserRepository _userRepository { get; }
    }
}
