using CVPZ.Application.Common.Behaviors;
using CVPZ.Application.Service;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace CVPZ.Application
{
    public static class ConfigureServices
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddTransient<IJournalService, JournalService>();
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(RequestPerformanceBehavior<,>));
        }
    }
}
