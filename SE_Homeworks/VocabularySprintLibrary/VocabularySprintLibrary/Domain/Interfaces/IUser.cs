using System;

namespace VocabularySprintLibrary.Domain.Interfaces
{
    public interface IUser
    {
         Guid UserId { get; }
         string Nickname { get; }
         DateTimeOffset RegistrationDate { get; }
         IVocabulary vocabulary { get; }
    }
}
