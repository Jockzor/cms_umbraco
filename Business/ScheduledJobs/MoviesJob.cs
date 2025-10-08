using cms_umbraco.Business.ScheduledJobs.Interfaces;
using Hangfire.Console;
using Hangfire.Server;

namespace cms_umbraco.Business.ScheduledJobs
{
    public class MoviesJob : IMoviesJob
    {

        public void AddMovies(PerformContext context)
        {
            var progressBar = context.WriteProgressBar();
            var movies = new List<MyMovie>();

            for (int i = 1; i <= 5000; i++)
            {
                var movie = new MyMovie
                {
                    Name = i.ToString()
                };

                movies.Add(movie);
            }
            foreach (var movie in movies.WithProgress(progressBar, movies.Count()))
            {
                context.WriteLine($"Movie {movie.Name} added");
            }
        }
    }

    internal class MyMovie
    {
        public string Name { get; set; }
    }
}
