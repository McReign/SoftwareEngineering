﻿using System;

namespace VocabularySprintLibrary.Domain.Interfaces
{
    public interface IWord
    {
         Guid WordId { get; }
         string Value { get; }
         string Translation { get; }
         DegreeOfLearn degreeOfLearn { get; set; }
         int countOfSuccess { get; set; }
    }
}
