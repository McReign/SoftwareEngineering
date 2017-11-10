using System;
using System.Collections.Generic;
using VocabularySprintLibrary.Domain.Interfaces;

namespace VocabularySprintLibrary.Domain
{
    public class Vocabulary : IVocabulary
    {
        public Vocabulary(Guid vocabularyId)
        {
            VocabularyId = vocabularyId;
            LearnedWords = new List<IWord>();
            UnlearnedWords = new List<IWord>();
        }

        public IEnumerable<IWord> LearnedWords { get; set; }
        public IEnumerable<IWord> UnlearnedWords { get; set; }

        public Guid VocabularyId { get; }
    }
}
