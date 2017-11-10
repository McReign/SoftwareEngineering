using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VocabularySprintLibrary;
using VocabularySprintLibrary.Application;
using VocabularySprintLibrary.Infrastructure;
using System.Linq;
using VocabularySprintLibrary.Domain.Interfaces;

namespace VocabularySprintLibraryTests
{
    [TestClass]
    public class TestForVocabularyService
    {
        [TestMethod]
        public void TryingToLearnWord_WordShouldBeLearned()
        {
            //Arrange
            IUser user = new User(Guid.NewGuid(), "Bob", DateTimeOffset.Now); 
            IVocabularyService vocabularyService = new VocabularyService(user);
            IWord word = new Word("Dog", "Собака");
            user.vocabulary.UnlearnedWords.ToList().Add(word);

            //Act
            vocabularyService.TracingRightAnswer(word);

            //Assert
            Assert.IsTrue(user.vocabulary.LearnedWords.ToList().Count > 0);
        }
    }
}
