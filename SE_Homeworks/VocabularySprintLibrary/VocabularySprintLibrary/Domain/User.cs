using System;
using System.Collections.Generic;

namespace VocabularySprintLibrary
{
    public class User
    {
        public User(Guid id, string nickname, DateTimeOffset registrationDate)
        {
            Id = id;
            Nickname = nickname;
            RegistrationDate = registrationDate;
        }

        public Guid Id { get; }
        public IEnumerable<Word> LearnedWords { get; set; }
        public IEnumerable<Word> UnlearnedWords { get; set; }
        public string Nickname { get; }
        public DateTimeOffset RegistrationDate { get; }
        
    }
}
