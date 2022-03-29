using System.Collections;

namespace lambdas_delegates
{
    // Instantiate delegate
    public delegate void ProcessMoviesCallback(Movie movie);

    public class MovieDatabase
    {
        ArrayList list = new ArrayList();

        public void AddMovie(int id, string title, string overview)
        {
            list.Add(new Movie(id, title, overview));
        }
        
        public void ProcessMovies(ProcessMoviesCallback process)
        {
            foreach (Movie m in list)
            {
                // Call the delegate process for each movie
                process(m);
            }
        }
    }
}