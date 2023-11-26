using OO.ContentContext.Enums;
using OO.SharedContext;

namespace OO.ContentContext

{
    public class Leacture : Base
    {
        public int Order { get; set; }
        public string Title { get; set; }
        public int DurationInMinutes { get; set; }
        public EContentLevel Level { get; set; }
    }
}