using VocabularySprintLibrary.Domain;
using VocabularySprintLibrary.Domain.Interfaces;

namespace VocabularySprintLibrary.Application
{
    public interface IVocabularyService
    {
        string[] GetRandomWord();
        bool CheckingAnswer(IWord word, bool answer);
        void TracingMistake(IWord word);
        void TracingRightAnswer(IWord word);
        bool IsContainingWord(IWord word);

        IVocabulary Vocabulary { get; }
        int MaxCountOfLearn { get; }
        int MinCountOfLearn { get; }
        string[] randomValuesForWord { get; }
    }
}
