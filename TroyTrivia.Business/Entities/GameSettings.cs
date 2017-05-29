using System.Collections.Generic;
using TroyTrivia.Business.Containers;

namespace TroyTrivia.Business.Entities
{
    public class GameSettings
    {
        public IList<PointSegment> PointSegments { get; set; }

        public GameSettings()
        {
            PointSegments = new List<PointSegment>();
        }
    }
}
