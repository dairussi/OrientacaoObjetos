namespace OO.ContentContext
{
    public class Career : Content
    {
        public Career(string title, string url) : base(title, url)
        {
            CareerItems = new List<CareerItem>();
        }
        public IList<CareerItem> CareerItems { get; set; }
        public int TotalCourses => CareerItems.Count;
    }

}