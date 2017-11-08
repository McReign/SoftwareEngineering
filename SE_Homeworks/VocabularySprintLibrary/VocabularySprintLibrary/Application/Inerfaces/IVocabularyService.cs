using VocabularySprintLibrary.Domain;

namespace VocabularySprintLibrary.Application
{
    internal interface IVocabularyService
    {
        Word GetRandomWord();
        bool CheckingAnswer(Word word, string answer);
        void TracingMistake(Word word);
        void TracingRightAnswer(Word word);
        bool IsContainingWord(Word word);
        IVocabulary _vocabulary { get; set; }
    }
}
