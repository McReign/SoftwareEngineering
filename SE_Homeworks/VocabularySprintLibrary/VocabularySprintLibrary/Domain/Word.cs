﻿using System;
using VocabularySprintLibrary.Domain;
using VocabularySprintLibrary.Domain.Interfaces;

namespace VocabularySprintLibrary
{
    public class Word : IWord
    {
        public Word(string value, string rightTranslation)
        {
            Value = value;
            RightTranslation = rightTranslation;
            degreeOfLearn = DegreeOfLearn.NotLearned;
            WordId = Guid.NewGuid();
            countOfSuccess = 0;
        }

        public Guid WordId { get; }
        public string Value { get; }
        public string RightTranslation { get; }
        public DegreeOfLearn degreeOfLearn { get; set; }
        public int countOfSuccess { get; set; }
        
    }
}
