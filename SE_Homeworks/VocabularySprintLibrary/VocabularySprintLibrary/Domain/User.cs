﻿using System;
using VocabularySprintLibrary.Domain;
using VocabularySprintLibrary.Domain.Interfaces;

namespace VocabularySprintLibrary
{
    public class User : IUser
    {
        public User(Guid id, string nickname, DateTimeOffset registrationDate)
        {
            UserId = id;
            Nickname = nickname;
            RegistrationDate = registrationDate;
            vocabulary = new Vocabulary(Guid.NewGuid());  
        }

        public Guid UserId { get; }
        public string Nickname { get; }
        public DateTimeOffset RegistrationDate { get; }
        public IVocabulary vocabulary { get; private set; }
        
    }
}
