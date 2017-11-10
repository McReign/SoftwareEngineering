using System;

namespace VocabularySprintLibrary
{
    public interface IUserService
    {
        Guid RegistrationUser(string nickname);
    }
}
