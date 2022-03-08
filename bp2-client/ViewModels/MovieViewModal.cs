using bp2_client.Models;
using Microsoft.AspNetCore.Components;

namespace bp2_client.ViewModels;

public class MovieViewModel : IMovieViewModel
{
    // You would use an API Manager in the ViewModel to do CRUD operations.

    public MovieViewModel()
    {
        InitializeViewModel().GetAwaiter().GetResult();
    }

    public async Task InitializeViewModel() // Could accept a primary key, etc.
    {
        await Task.Delay(0); //delete after actual async thing
        // initialize here
        movies = new List<Movie>();
        movies.Add(new Movie()
        {
            ID = 1, title = "Red Notice",
            overview = "An Interpol-issued Red Notice is a global alert to hunt and capture the world's most wanted. " +
                       "But when a daring heist brings together the FBI's top profiler and two rival criminals, " +
                       "there's no telling what will happen."
        });
        movies.Add(new Movie()
        {
            ID = 2, title = "Eternals",
            overview =
                "The Eternals are a team of ancient aliens who have been living on Earth in secret for thousands" +
                " of years. When an unexpected tragedy forces them out of the shadows, they are forced to reunite " +
                "against mankind’s most ancient enemy, the Deviants."
        });
        movies.Add(new Movie()
        {
            ID = 3, title = "Venom: Let There Be Carnage",
            overview = "After finding a host body in investigative reporter Eddie Brock, the alien symbiote must face" +
                       " a new enemy, Carnage, the alter ego of serial killer Cletus Kasady."
        });
    }

    public string InfoMessage { get; set; } = "";
    public string ErrorMessage { get; set; } = "";
    public string SearchTerm { get; set; } = "";
    public bool Adding { get; set; } = false;

    private List<Movie> movies = new List<Movie>();

    public List<Movie> Movies
    {
        get
        {
            return movies.Where(x => x.title.ToLower().Contains(SearchTerm.ToLower())
                                     || x.title.ToLower().Contains(SearchTerm.ToLower())).ToList();
        }
    }

    public Movie SelectedMovie { get; set; }

    public void NewMovie()
    {
        InfoMessage = "";
        ErrorMessage = "";
        Adding = true;
        SelectedMovie = new Movie();
        SelectedMovie.ID = movies.Count + 1;
    }

    public async Task<Movie> GetMovie(int id)
    {
        InfoMessage = "";
        ErrorMessage = "";
        Adding = false;
        await Task.Delay(0);
        return (from x in movies where x.ID == id select x).FirstOrDefault();
    }

    public async Task UpdateSelectedMovie()
    {
        InfoMessage = "";
        ErrorMessage = "";
        Adding = false;
        await Task.Delay(0);
        var cust = (from x in movies where x.ID == SelectedMovie.ID select x).FirstOrDefault();
        if (cust != null)
        {
            var index = movies.IndexOf(cust);
            movies[index] = SelectedMovie;
            InfoMessage = "Movie updated.";
        }
        else
        {
            ErrorMessage = "Movie not found.";
        }
    }

    public async Task AddMovie()
    {
        InfoMessage = "";
        ErrorMessage = "";
        Adding = false;
        await Task.Delay(0);
        try
        {
            movies.Add(SelectedMovie);
            InfoMessage = "Movie added.";
        }
        catch
        {
            ErrorMessage = "Could not add movie.";
        }
    }

    public async Task DeleteMovie(Movie movie)
    {
        InfoMessage = "";
        ErrorMessage = "";
        await Task.Delay(0);
        try
        {
            movies.Remove(movie);
            InfoMessage = "Movie deleted.";
        }
        catch
        {
            ErrorMessage = "Movie not found.";
        }
    }
}