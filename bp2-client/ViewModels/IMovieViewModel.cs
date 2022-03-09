using bp2_client.Models;

namespace bp2_client.ViewModels;

public interface IMovieViewModel
{
    string InfoMessage { get; set; }
    string ErrorMessage { get; set; }
    string SearchTerm { get; set; }
    bool ShowCreateMovieForm { get; set; }
    void NewMovie();
    List<Movie> Movies { get; }
    Movie SelectedMovie { get; set; }
    Task<Movie> GetMovie(int id);
    Task UpdateSelectedMovie();
    Task AddMovie();
    Task DeleteMovie(Movie id);
    Task RetrieveMoviesAsync();
}