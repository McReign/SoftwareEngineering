using System;

namespace VocabularySprintLibrary.Domain.Interfaces
{
    public interface IWord
    {
         Guid WordId { get; }
         string Value { get; }
         string RightTranslation { get; }
         DegreeOfLearn degreeOfLearn { get; set; }
         int countOfSuccess { get; set; }
    }
}
