using System;
using System.Collections.Generic;
using System.Linq;
using VocabularySprintLibrary.Domain;

namespace VocabularySprintLibrary.Application
{
    internal class VocabularyService : IVocabularyService
    {
        public VocabularyService(User user)
        {
            _vocabulary.LearnedWords = user.vocabulary.LearnedWords;
            _vocabulary.UnlearnedWords = user.vocabulary.UnlearnedWords;

            random = new Random();
        }

        public bool CheckingAnswer(Word word, string answer)
        {
            if (IsContainingWord(word))
            {
                throw new NotImplementedException();
            }
            
            if (word.RightTranslation.Equals(answer))
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

        public void TracingMistake(Word word)
        {
            //throw new NotImplementedException();
            word.countOfSuccess = 0;
            word.degreeOfLearn = DegreeOfLearn.NotLearned;
            /*
            List<Word> unlearnedWords = _vocabulary.UnlearnedWords.ToList();
            List<Word> learnedWords = _vocabulary.LearnedWords.ToList();
            learnedWords.Remove(learnedWords.Find(current => (current.WordId == word.WordId)));
            unlearnedWords.Add(word);
            _vocabulary.UnlearnedWords = unlearnedWords;
            _vocabulary.LearnedWords = learnedWords;
            */
        }

        public void TracingRightAnswer(Word word)
        {
            if (IsContainingWord(word))
            {
                throw new NotImplementedException();
            }

            word.countOfSuccess++;

            if(word.countOfSuccess == 3)
            {
                word.degreeOfLearn = DegreeOfLearn.Learned;
                List<Word> unlearnedWords = _vocabulary.UnlearnedWords.ToList();
                List<Word> learnedWords = _vocabulary.LearnedWords.ToList();
                unlearnedWords.Remove(unlearnedWords.Find(current => (current.WordId == word.WordId)));
                learnedWords.Add(word);
                _vocabulary.UnlearnedWords = unlearnedWords;
                _vocabulary.LearnedWords = learnedWords;
            }
        }

        public Word GetRandomWord()
        {
            int IndexOfWordsValue = random.Next(_vocabulary.UnlearnedWords.ToList().Count - 1);
            int IndexOfWordsTranslation = random.Next(_vocabulary.UnlearnedWords.ToList().Count - 1);
            Word randomWord = new Word(_vocabulary.UnlearnedWords.ToList()[IndexOfWordsValue].Value, 
                _vocabulary.UnlearnedWords.ToList()[IndexOfWordsTranslation].RightTranslation);

            return randomWord;
        }

        public bool IsContainingWord(Word word)
        {
            return (_vocabulary.UnlearnedWords.ToList().Exists(current => current.WordId == word.WordId));
        }

        public IVocabulary _vocabulary { get; set; }

        //private readonly IWordRepository _wordRepository;

        Random random;
    }
}
