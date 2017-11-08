using System.Collections.Generic;
using System.Linq;
using VocabularySprintLibrary.Domain;

namespace VocabularySprintLibrary.Infrastructure
{
    internal class InMemoryWordRepository : IWordRepository
    {
        public InMemoryWordRepository(InMemoryUserRepository userRepository)
        {
            _userRepository = userRepository;
            file = new File();
        }

        public IEnumerable<Word> LoadLearnedWords(User user)
        {
            return file.ReadFromFile<List<Word>>(user.UserId.ToString() + "/Learned Words.json");
        }

        public IEnumerable<Word> LoadUnlearnedWords(User user)
        {
            return file.ReadFromFile<List<Word>>(user.UserId.ToString() + "/Unlearned Words.json");
        }

        public void AddWord(User user, Word word)
        {
            user.vocabulary.UnlearnedWords.ToList().Add(word);
            _userRepository.SaveUser(user);
        }

        public File file { get; }
        public IUserRepository _userRepository { get; }
    }
}
