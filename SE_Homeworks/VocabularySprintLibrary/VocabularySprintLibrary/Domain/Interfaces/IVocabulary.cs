using System;
using System.Collections.Generic;
using VocabularySprintLibrary.Domain.Interfaces;

namespace VocabularySprintLibrary.Domain
{
    public interface IVocabulary
    {
        IEnumerable<IWord> LearnedWords { get; set; }
        IEnumerable<IWord> UnlearnedWords { get; set; }

        Guid VocabularyId { get; }
    }
}
