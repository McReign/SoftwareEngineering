using System.Collections.Generic;
using System.Linq;
using VocabularySprintLibrary.Domain;
using VocabularySprintLibrary.Domain.Interfaces;

namespace VocabularySprintLibrary.Infrastructure
{
    public class InFolderWordRepository : IWordRepository
    {
        public InFolderWordRepository(InFolderUserRepository userRepository)
        {
            _userRepository = userRepository;
            file = new File();
        }

        public IEnumerable<IWord> LoadLearnedWords(IUser user)
        {
            return file.ReadFromFile<List<IWord>>(user.UserId.ToString() + "/Learned Words.json");
        }

        public IEnumerable<IWord> LoadUnlearnedWords(IUser user)
        {
            return file.ReadFromFile<List<IWord>>(user.UserId.ToString() + "/Unlearned Words.json");
        }

        public void AddWord(IUser user, IWord word)
        {
            user.vocabulary.UnlearnedWords.ToList().Add(word);
            _userRepository.SaveUser(user);
        }

        public File file { get; }
        public IUserRepository _userRepository { get; }
    }
}
