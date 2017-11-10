using System;
using System.Collections.Generic;
using System.Linq;
using VocabularySprintLibrary.Domain;
using VocabularySprintLibrary.Domain.Interfaces;

namespace VocabularySprintLibrary.Infrastructure
{
    public class InFolderUserRepository : IUserRepository
    {
        public InFolderUserRepository()
        {
            
            users = new List<IUser>();
            //users = file.ReadFromFile<List<IUser>>("Users.json");

            wordRepository = new InFolderWordRepository(this);
            file = new File();
        }

        public IEnumerable<IUser> LoadAllUsers()
        {
            users.Select(currentUser => (currentUser.vocabulary.LearnedWords = wordRepository.LoadLearnedWords(currentUser)));
            users.Select(currentUser => (currentUser.vocabulary.UnlearnedWords = wordRepository.LoadUnlearnedWords(currentUser)));

            return users;
        }

        public IUser LoadUser(Guid userId)
        {
            IUser user = users.ToList().Find(current => current.UserId == userId);

            if (user == null)
            {
                throw new NotImplementedException();
            }

            //user.vocabulary.LearnedWords = wordRepository.LoadLearnedWords(user);
            //user.vocabulary.UnlearnedWords = wordRepository.LoadUnlearnedWords(user);

            return user;
        }

        public void SaveUser(IUser user)
        {
            if (user == null)
            {
                throw new NotImplementedException();
            }

            List<IUser> listOfUsers = users.ToList();
            listOfUsers.Add(user);
            users = listOfUsers;

            //file.SaveToFile("Users.json", listOfUsers);
            
            //file.SaveToFile("Learned Words.json", user.vocabulary.LearnedWords);
            //file.SaveToFile("Unlearned Words.json", user.vocabulary.UnlearnedWords);
        }

        public File file { get; }
        public IEnumerable<IUser> users { get; set; }
        public IWordRepository wordRepository { get; }
    }
}
