using Hangfire.Server;

namespace cms_umbraco.Business.ScheduledJobs.Interfaces
{
    public interface IMoviesJob
    {
        void AddMovies(PerformContext context);
    }
}
