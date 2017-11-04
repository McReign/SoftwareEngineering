using System;
using System.Collections.Generic;

namespace VocabularySprintLibrary
{
    public interface IUserRepository
    {
        User LoadUser(Guid userId);
        void SaveUser(User user);
        IEnumerable<User> LoadAllUsers();
    }
}
