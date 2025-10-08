using cms_umbraco.Business.ScheduledJobs.Interfaces;
using Hangfire;
using Umbraco.Cms.Core.Composing;

namespace cms_umbraco.Business.Composers
{
    public class ScheduledJobsComposer : IComposer
    {
        public void Compose(IUmbracoBuilder builder)
        {
            RecurringJob.AddOrUpdate<IMoviesJob>("AddMovies", x => x.AddMovies(null), Cron.Never);
        }
    }
}
