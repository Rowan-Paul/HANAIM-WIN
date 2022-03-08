using bp2_client.Models;
using Microsoft.AspNetCore.Components;

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
    Task<Movie> GetMovie(int Id);
    Task UpdateSelectedMovie();
    Task AddMovie();
    Task DeleteMovie(Movie id);
}