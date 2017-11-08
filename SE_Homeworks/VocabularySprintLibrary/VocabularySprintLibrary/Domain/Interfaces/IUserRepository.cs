using System;
using System.Collections.Generic;
using VocabularySprintLibrary.Domain;
using VocabularySprintLibrary.Infrastructure;

namespace VocabularySprintLibrary
{
    internal interface IUserRepository
    {
        User LoadUser(Guid userId);
        void SaveUser(User user);
        IEnumerable<User> LoadAllUsers();

        File file { get; }
        IEnumerable<User> users { get; }
        IWordRepository wordRepository { get; }
    }
}
