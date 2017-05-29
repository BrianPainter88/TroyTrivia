using System;
using System.Collections.Generic;
using System.Linq;
using TroyTrivia.Business.Containers;

namespace TroyTrivia.Business.Entities
{
    public class Game
    {
        public Guid Id { get; set; }
        public GameSettings Settings { get; set; }
        public IList<TeamSegment> Teams { get; set; }
        public ScoreBoard ScoreBoard { get; set; }
        public IEnumerable<Question> Questions { get; set; }
        public Location Location { get; set; }

        public Game(GameSettings settings)
        {
            Id = Guid.NewGuid();
            Settings = settings;
            ScoreBoard = new ScoreBoard();
            Teams = new List<TeamSegment>();
            Questions = new HashSet<Question>();
        }

        public void AddTeamsToScoreBoard()
        {
            foreach (var team in Teams.Select(seg => seg.Team))
            {
                try
                {
                    ScoreBoard.Scores.Add(team.Name, 0);
                }
                catch (Exception)
                {
                    Console.WriteLine("\"{0}\" already exists on the ScoreBoard.", team.Name);
                }
            }
        }
    }
}
