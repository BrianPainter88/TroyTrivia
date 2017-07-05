using System.Collections.Generic;

namespace TroyTrivia.Business.Containers
{
    public class PointSegment
    {
        private static readonly int _defaultQuestionCount = 3;

        public int QuestionCount { get; set; }
        public HashSet<int> PointScale { get; set; }

        public PointSegment()
        {
            QuestionCount = _defaultQuestionCount;
            PointScale = new HashSet<int>() {1, 3, 5};
        }

        public PointSegment(HashSet<int> pointScale)
        {
            QuestionCount = _defaultQuestionCount;
            PointScale = pointScale;
        }
    }
}
