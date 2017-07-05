using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TroyTrivia.Business.Entities;
using TroyTrivia.Business.Containers;

namespace TroyTrivia.Business.Interactors
{
    public class QuestionsInteractor
    {
        public static async Task<bool> CreateOpenTriviaDbQuestions()
        {
            var response = await HttpInteractor.GetResponseFromUrl(OpenTriviaDb.ApiUrl);

            var questions = JsonInteractor.SerializeToObject<OpenTriviaDb>(response);

            var validQuestions = OpenTriviaDb.RemoveForbiddenCategoriesFromQuestions(questions).ToList();

            InsertMissingCategories(validQuestions);
            InsertMissingTypes(validQuestions);
            InsertMissingDifficulties(validQuestions);

            CreateNewQuestions(validQuestions);
            RemoveDuplicateQuestions();

            return true;
        }

        private static void InsertMissingCategories(IEnumerable<OpenTriviaDb.Result> validQuestions)
        {
            foreach (var category in validQuestions.Select(r => r.Category))
            {
                if (Category.Select(category) == null)
                {
                    var newCategory = new Category
                    {
                        Name = category
                    };
                    newCategory.Insert();
                }
            }
        }

        private static void InsertMissingTypes(IEnumerable<OpenTriviaDb.Result> validQuestions)
        {
            foreach (var type in validQuestions.Select(r => r.Type))
            {
                if (QuestionType.Select(type) == null)
                {
                    var newQuestionType = new QuestionType
                    {
                        Name = type
                    };

                    newQuestionType.Insert();
                }
            }
        }

        private static void InsertMissingDifficulties(IEnumerable<OpenTriviaDb.Result> validQuestions)
        {
            foreach (var difficulty in validQuestions.Select(r => r.Difficulty))
            {
                if (QuestionDifficulty.Select(difficulty) == null)
                {
                    var newDifficulty = new QuestionDifficulty
                    {
                        Name = difficulty
                    };
                    newDifficulty.Insert();
                }
            }
        }

        private static void CreateNewQuestions(IEnumerable<OpenTriviaDb.Result> validQuestions)
        {
            foreach (var question in validQuestions)
            {
                var type = QuestionType.Select(question.Type);
                var difficulty = QuestionDifficulty.Select(question.Difficulty);
                var category = Category.Select(question.Category);
                var answers = CreateAnswerKey(question);
  
                var newQuestion = new Question
                {
                    Category = category,
                    Difficulty = difficulty,
                    QuestionText = question.Question,
                    Type = type,
                    Answer = answers
                };

                newQuestion.Insert();
            }
        }

        private static IEnumerable<AnswerKey> CreateAnswerKey(OpenTriviaDb.Result question)
        {
            var answerKey = new List<AnswerKey>()
                {
                    new AnswerKey()
                    {
                        Text = question.CorrectAnswer,
                        Order = 1,
                        Description = "Correct Answer"
                    }
                };

            var loopCounter = 2;
            foreach (var incorrectAnswer in question.IncorrectAnswers)
            {
                answerKey.Add(
                    new AnswerKey
                    {
                        Text = incorrectAnswer,
                        Order = loopCounter,
                        Description = "Incorrect Answer"
                    }
                );
                loopCounter++;
            }

            return answerKey;
        }

        private static void RemoveDuplicateQuestions()
        {
            var allQuestions = Question.Select().ToList();

            var goodQuestions = allQuestions.GroupBy(x => x.QuestionText).Select(x => x.First()).ToList();

            var badQuestions = allQuestions.Except(goodQuestions).ToList();

            foreach (var question in badQuestions)
            {
                question.Delete();
            }
        }
    }
}
