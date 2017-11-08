using System;
using System.Collections.Generic;

namespace VocabularySprintLibrary.Domain
{
    internal class Vocabulary : IVocabulary
    {
        public Vocabulary(Guid vocabularyId)
        {
            VocabularyId = vocabularyId;
        }

        public IEnumerable<Word> LearnedWords { get; set; }
        public IEnumerable<Word> UnlearnedWords { get; set; }

        public Guid VocabularyId { get; }
    }
}
