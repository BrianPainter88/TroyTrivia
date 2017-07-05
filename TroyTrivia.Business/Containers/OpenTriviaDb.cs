using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TroyTrivia.Business.Containers
{
    internal class OpenTriviaDb
    {
        private const string _openTriviaDbApiUrl = "https://opentdb.com/api.php?amount=50";

        private static readonly List<string> _forbiddenOpenTriviaDbCategories = new List<string>{
            "Entertainment: Japanese Anime & Manga",
            "Entertainment: Video Games"
        };

        public int ResponseCode { get; set; }
        public IList<Result> Results { get; set; }

        [JsonIgnore]
        public static string ApiUrl => _openTriviaDbApiUrl;

        public static IEnumerable<Result> RemoveForbiddenCategoriesFromQuestions(OpenTriviaDb questions)
        {
            return questions.Results.Where(r => false == _forbiddenOpenTriviaDbCategories.Contains(r.Category));
        }

        public class Result
        {
            public string Category { get; set; }
            public string Type { get; set; }
            public string Difficulty { get; set; }
            public string Question { get; set; }
            [JsonProperty("correct_answer")]
            public string CorrectAnswer { get; set; }
            [JsonProperty("incorrect_answers")]
            public IList<string> IncorrectAnswers { get; set; }
        }
    }
}
