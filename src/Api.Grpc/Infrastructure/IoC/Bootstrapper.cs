using Manifest.Api.Domain.Interfaces.Repositories;
using Manifest.Api.Infrastructure.Data;
using Manifest.Api.Infrastructure.Data.Repositories;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Manifest.Api.Grpc.Infrastructure.IoC
{
    public static class Bootstrapper
    {
        public static void Inject(IServiceCollection services)
        {
            BaseInjection(services);
            InjectRepositories(services);
        }

        public static void BaseInjection(IServiceCollection services)
        {
            services.AddMediatR(typeof(Startup));
            services.AddSingleton<ILoggerFactory, LoggerFactory>();
        }

        public static void InjectRepositories(IServiceCollection services)
        {
            //services.AddScoped(typeof(SqlConnection));
            services.AddSingleton<IManifestRepository, ManifestRepository>();
            services.AddSingleton<IFlightRepository, FlightRepository>();
        }
    }
}