using System;
using System.Collections.Generic;
using System.Linq;
using VocabularySprintLibrary.Domain;

namespace VocabularySprintLibrary.Infrastructure
{
    internal class InMemoryUserRepository : IUserRepository
    {
        public InMemoryUserRepository()
        {
            users = file.ReadFromFile<List<User>>("Users.json");
            wordRepository = new InMemoryWordRepository(this);
            file = new File();
        }

        public IEnumerable<User> LoadAllUsers()
        {
            users.Select(currentUser => (currentUser.vocabulary.LearnedWords = wordRepository.LoadLearnedWords(currentUser)));
            users.Select(currentUser => (currentUser.vocabulary.UnlearnedWords = wordRepository.LoadUnlearnedWords(currentUser)));

            return users;
        }

        public User LoadUser(Guid userId)
        {
            User user = users.ToList().Find(current => current.UserId == userId);

            if (user == null)
            {
                throw new NotImplementedException();
            }

            user.vocabulary.LearnedWords = wordRepository.LoadLearnedWords(user);
            user.vocabulary.UnlearnedWords = wordRepository.LoadUnlearnedWords(user);

            return user;
        }

        public void SaveUser(User user)
        {
            if (user == null)
            {
                throw new NotImplementedException();
            }

            List<User> listOfUsers = users.ToList();
            listOfUsers.Add(user);

            file.SaveToFile("Users.json", listOfUsers);
            
            file.SaveToFile(user.UserId.ToString() + "/Learned Words.json", user.vocabulary.LearnedWords);
            file.SaveToFile(user.UserId.ToString() + "/Unlearned Words.json", user.vocabulary.UnlearnedWords);
        }

        public File file { get; }
        public IEnumerable<User> users { get; }
        public IWordRepository wordRepository { get; }
    }
}
