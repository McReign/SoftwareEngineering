using System;

namespace VocabularySprintLibrary
{
    public class Word : IWord
    {
        public Word(string value, string rightTranslation)
        {
            Value = value;
            RightTranslation = rightTranslation;
        }

        public string Value { get; }

        public string RightTranslation { get; }
    }
}
