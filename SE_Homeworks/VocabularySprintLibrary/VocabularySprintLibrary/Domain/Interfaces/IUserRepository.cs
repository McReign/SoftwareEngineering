using System;
using System.Collections.Generic;
using VocabularySprintLibrary.Domain;
using VocabularySprintLibrary.Domain.Interfaces;
using VocabularySprintLibrary.Infrastructure;

namespace VocabularySprintLibrary
{
    public interface IUserRepository
    {
        IUser LoadUser(Guid userId);
        void SaveUser(IUser user);
        IEnumerable<IUser> LoadAllUsers();

        File file { get; }
        IEnumerable<IUser> users { get; }
        IWordRepository wordRepository { get; }
    }
}
