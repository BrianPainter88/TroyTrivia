using System.Collections.Generic;
using TroyTrivia.Business.Entities;

namespace TroyTrivia.Business.Containers
{
    public class TeamSegment
    {
        public Team Team { get; set; }
        public HashSet<int> ChosenPoints { get; set; }

        public TeamSegment()
        {
            ChosenPoints = new HashSet<int>();
        }

        public bool SelectPointValue(int pointValue)
        {
            return ChosenPoints.Add(pointValue);
        }

        public bool HasPointValueBeenChosen(int pointValue)
        {
            return ChosenPoints.Contains(pointValue);
        }

        public void ResetSegmentPointValues()
        {
            ChosenPoints.Clear();
        }
    }
}
