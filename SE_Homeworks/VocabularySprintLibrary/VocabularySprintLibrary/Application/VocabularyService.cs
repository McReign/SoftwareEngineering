using System;
using System.Collections.Generic;
using System.Linq;
using VocabularySprintLibrary.Domain;
using VocabularySprintLibrary.Domain.Interfaces;

namespace VocabularySprintLibrary.Application
{
    public class VocabularyService : IVocabularyService
    {
        public VocabularyService(IUser user)
        {
            Vocabulary.LearnedWords = user.vocabulary.LearnedWords;
            Vocabulary.UnlearnedWords = user.vocabulary.UnlearnedWords;

            MaxCountOfLearn = 3;
            MinCountOfLearn = 0;

            random = new Random();
        }

        public bool CheckingAnswer(IWord word, bool answer)
        {
            if (IsContainingWord(word))
            {
                throw new NotImplementedException();
            }
            
            if (word.Translation.Equals(randomValuesForWord[1]) == answer)
            {
                TracingRightAnswer(word);
                return true;
            }
            else
            {
                TracingMistake(word);
                return false;
            }
        }

        public void TracingMistake(IWord word)
        {
            word.countOfSuccess = MinCountOfLearn;
            word.degreeOfLearn = DegreeOfLearn.NotLearned;
        }

        public void TracingRightAnswer(IWord word)
        {
            if (IsContainingWord(word))
            {
                throw new NotImplementedException();
            }

            word.countOfSuccess++;

            if(word.countOfSuccess == MaxCountOfLearn)
            {
                word.degreeOfLearn = DegreeOfLearn.Learned;
                List<IWord> unlearnedWords = Vocabulary.UnlearnedWords.ToList();
                List<IWord> learnedWords = Vocabulary.LearnedWords.ToList();
                unlearnedWords.Remove(unlearnedWords.Find(current => (current.WordId == word.WordId)));
                learnedWords.Add(word);
                Vocabulary.UnlearnedWords = unlearnedWords;
                Vocabulary.LearnedWords = learnedWords;
            }
        }

        public string[] GetRandomWord()
        {
            int IndexOfWordsValue = random.Next(Vocabulary.UnlearnedWords.ToList().Count - 1);
            int IndexOfWordsTranslation = random.Next(Vocabulary.UnlearnedWords.ToList().Count - 1);
            string randomValue = Vocabulary.UnlearnedWords.ToList()[IndexOfWordsValue].Value;
            string randomTranslation = Vocabulary.UnlearnedWords.ToList()[IndexOfWordsTranslation].Translation;

            randomValuesForWord = new string[2] { randomValue, randomTranslation };

            return randomValuesForWord;
        }

        public bool IsContainingWord(IWord word)
        {
            return (Vocabulary.UnlearnedWords.ToList().Exists(current => current.WordId == word.WordId));
        }

        public IVocabulary Vocabulary { get; private set; }
        public int MaxCountOfLearn { get; }
        public int MinCountOfLearn { get; }
        public string[] randomValuesForWord { get; private set; }

        Random random;
    }
}
