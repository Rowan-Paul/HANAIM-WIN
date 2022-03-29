using System;

namespace lambdas_delegates
{
    internal class Program
    {
        private static Boolean isAdmin = true;

        public static void Main(string[] args)
        {
            // Create "database"
            MovieDatabase movieDatabase = new MovieDatabase();

            // Add some movies to the database
            movieDatabase.AddMovie(1, "Red Notice",
                "An Interpol-issued Red Notice is a global alert to hunt and capture the world's most wanted. " +
                "But when a daring heist brings together the FBI's top profiler and two rival criminals, " +
                "there's no telling what will happen.");
            movieDatabase.AddMovie(2, "Eternals",
                "The Eternals are a team of ancient aliens who have been living on Earth in secret " +
                "for thousands of years. When an unexpected tragedy forces them out of the shadows, " +
                "they are forced to reunite against mankind’s most ancient enemy, the Deviants.");

            // If the user is an admin, use a different function
            if (isAdmin)
            {
                movieDatabase.ProcessMovies((movie) =>
                {
                    Console.WriteLine("ID: " + movie.ID);
                    Console.WriteLine("Title: " + movie.Title + "\n===");
                });
            }
            else
            {
                movieDatabase.ProcessMovies((movie) => Console.WriteLine("Title: " + movie.Title + "\n==="));
            }
        }
    }
}