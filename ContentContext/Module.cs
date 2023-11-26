using OO.SharedContext;

namespace OO.ContentContext
{
    public class Module : Base
    {
        public Module()
        {
            Leactures = new List<Leacture>();
        }
        public int Order { get; set; }
        public string Title { get; set; }
        public IList<Leacture> Leactures { get; set; }
    }

}