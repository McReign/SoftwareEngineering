using System;

namespace VocabularySprintLibrary
{
    internal interface IUserService
    {
        Guid RegistrationUser(string nickname);
    }
}
