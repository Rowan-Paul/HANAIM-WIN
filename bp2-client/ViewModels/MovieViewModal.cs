using System.Text;
using bp2_client.Models;
using Newtonsoft.Json;

namespace bp2_client.ViewModels;

public class MovieViewModel : IMovieViewModel
{
    private HttpClient _http = new();

    public string InfoMessage { get; set; } = "";
    public string ErrorMessage { get; set; } = "";
    public string SearchTerm { get; set; } = "";
    public Movie SelectedMovie { get; set; } = new();
    public bool ShowCreateMovieForm { get; set; }
    private List<Movie> _movies = new();

    public List<Movie> Movies
    {
        get
        {
            return _movies.Where(x => x.title.ToLower().Contains(SearchTerm.ToLower())
                                      || x.title.ToLower().Contains(SearchTerm.ToLower())).ToList();
        }
    }

    public async Task RetrieveMoviesAsync()
    {
        try
        {
            Movie[] temp = await _http.GetFromJsonAsync<Movie[]>("https://localhost:44390/api/movies") ??
                           Array.Empty<Movie>();
            _movies = temp.ToList();
        }
        catch
        {
            ErrorMessage = "Failed to get movies";
        }
    }


    public void NewMovie()
    {
        InfoMessage = "";
        ErrorMessage = "";
        SelectedMovie = new Movie();
        ShowCreateMovieForm = true;
    }

    public async Task<Movie> GetMovie(int id)
    {
        InfoMessage = "";
        ErrorMessage = "";
        ShowCreateMovieForm = false;
        await Task.Delay(0);
        return (from x in _movies where x.ID == id select x).FirstOrDefault()!;
    }

    public async Task UpdateSelectedMovie()
    {
        InfoMessage = "";
        ErrorMessage = "";
        ShowCreateMovieForm = false;
        await Task.Delay(0);
        var m = (from x in _movies where x.ID == SelectedMovie.ID select x).FirstOrDefault();
        if (m != null)
        {
            var index = _movies.IndexOf(m);
            _movies[index] = SelectedMovie;
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
        ShowCreateMovieForm = false;

        try
        {
            var json = JsonConvert.SerializeObject(SelectedMovie);
            var stringContent = new StringContent(json, Encoding.UTF8, "application/json");
            
            var response = await _http.PostAsync("https://localhost:44390/api/movies", stringContent);

            if (response.IsSuccessStatusCode)
            {
                _movies.Add(SelectedMovie);
                InfoMessage = "Movie added.";
            }
            else
            {
                ErrorMessage = "Could not add movie.";
            }
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

        try
        {
            var response = await _http.DeleteAsync($"https://localhost:44390/api/movies/{movie.ID}");

            if (response.IsSuccessStatusCode)
            {
                _movies.Remove(movie);
                InfoMessage = "Movie deleted.";
            }
            else
            {
                ErrorMessage = "Failed to delete movie";
            }
        }
        catch
        {
            ErrorMessage = "Failed to delete movie";
        }
    }
}