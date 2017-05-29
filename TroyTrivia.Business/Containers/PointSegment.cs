using System.Collections.Generic;

namespace TroyTrivia.Business.Containers
{
    public class PointSegment
    {
        public int QuestionCount { get; set; }
        public HashSet<int> PointScale { get; set; }

        public PointSegment()
        {
            QuestionCount = 3;
            PointScale = new HashSet<int>() {1, 3, 5};
        }
    }
}
