using System;
using System.Collections.Generic;

namespace VocabularySprintLibrary.Domain
{
    internal interface IVocabulary
    {
        IEnumerable<Word> LearnedWords { get; set; }
        IEnumerable<Word> UnlearnedWords { get; set; }

        Guid VocabularyId { get; }
    }
}
