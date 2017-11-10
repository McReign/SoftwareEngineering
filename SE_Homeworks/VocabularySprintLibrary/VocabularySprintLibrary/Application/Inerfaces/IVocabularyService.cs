using VocabularySprintLibrary.Domain;
using VocabularySprintLibrary.Domain.Interfaces;

namespace VocabularySprintLibrary.Application
{
    public interface IVocabularyService
    {
        IWord GetRandomWord();
        bool CheckingAnswer(IWord word, string answer);
        void TracingMistake(IWord word);
        void TracingRightAnswer(IWord word);
        bool IsContainingWord(IWord word);

        IVocabulary Vocabulary { get; }
        int MaxCountOfLearn { get; }
        int MinCountOfLearn { get; }
    }
}
