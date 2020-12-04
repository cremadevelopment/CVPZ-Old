using CVPZ.Core.Entities;
using CVPZ.Core.Repository;
using CVPZ.Infrastructure.Data;
using CVPZ.Infrastructure.Factories;
using CVPZ.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Tactical.DDD.EventSourcing;

namespace CVPZ.Infrastructure
{
    public static class ConfigureServices
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration Configuration)
        {
            services.AddDbContext<CVPZContext>(options =>
                options.UseSqlite(
                    Configuration.GetConnectionString("CVPZConnection")));

            services.AddSingleton<ISqlConnectionFactory>(new SqlConnectionFactory(Configuration.GetConnectionString("EventStoreDatabase")));

            services.AddTransient<IEventStore, EventStoreRepository>();
            services.AddTransient<IRepository<JournalEntry>, JournalEntryRepository>();
            services.AddTransient<IResumeRepository, ResumeRepository>();
        }
    }
}
