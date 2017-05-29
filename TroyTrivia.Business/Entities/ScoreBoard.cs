using System.Collections.Generic;
using System.Linq;

namespace TroyTrivia.Business.Entities
{
    public class ScoreBoard
    {
        public Dictionary<string, int> Scores { get; set; }

        public ScoreBoard()
        {
            Scores = new Dictionary<string, int>();
        }

        public void IncrementScore(string teamName, int points)
        {
            Scores[teamName] += points;
        }

        public void DecrementScore(string teamName, int points)
        {
            Scores[teamName] -= points;
        }

        public int GetTeamScore(string teamName)
        {
            return Scores[teamName];
        }

        public IOrderedEnumerable<KeyValuePair<string, int>> GetCurrentLeaderboard()
        {
            return Scores.OrderByDescending(scores => scores.Value);
        }
    }
}
