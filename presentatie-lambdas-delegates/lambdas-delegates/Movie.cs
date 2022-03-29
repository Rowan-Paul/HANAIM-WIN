namespace lambdas_delegates
{
    public struct Movie
    {
        public int ID;
        public string Title;
        public string Overview;

        public Movie(int id, string title, string overview)
        {
            ID = id;
            Title = title;
            Overview = overview;
        }
    }
}