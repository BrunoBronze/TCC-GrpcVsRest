using System;
using Manifest.Api.Domain.Interfaces.Repositories;
using Manifest.Api.Domain.Queries.v1;
using Manifest.Api.Infrastructure.Data.Repositories;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System.Data;
using System.Data.SqlClient;

namespace Manifest.Api.Rest.Infrastructure.IoC
{
    public static class Bootstrapper
    {
        private static readonly string _connectionString = "Data Source=BRUNOBRONZE\\SQLEXPRESS;Initial Catalog=RestVsGRPC;Integrated Security=True;";

        public static void Inject(IServiceCollection services)
        {

            BaseInjection(services);
            var serviceProvider = services.BuildServiceProvider();

            InjectMediator(services);
            InjectMapper(services);
            InjectRepositories(services, serviceProvider);
            //var mapper = ConfigureMapper();
            //services.AddSingleton(mapper);
        }

        public static void BaseInjection(IServiceCollection services)
        {
            services.AddSingleton<ILoggerFactory, LoggerFactory>();
            services.AddScoped<IDbConnection>(dbc => new SqlConnection(_connectionString));
        }

        private static void InjectMediator(IServiceCollection services)
        {
            services.AddMediatR(typeof(GetAllManifestsQueryHandler).Assembly);
        }

        public static void InjectMapper(IServiceCollection services)
        {
            services.AddAutoMapper(typeof(GetAllManifestsQueryProfile).Assembly);
        }

        public static void InjectRepositories(IServiceCollection services, IServiceProvider serviceProvider)
        {
            services.AddSingleton<IManifestRepository>(mr =>
                new ManifestRepository(serviceProvider.GetService<IDbConnection>()));

            services.AddSingleton<IFlightRepository>(fr =>
                new FlightRepository(serviceProvider.GetService<IDbConnection>()));
        }

        //private static IMapper ConfigureMapper()
        //{
        //    var mapperConfiguration = new MapperConfiguration(x =>
        //    {
        //        x.Advanced.AllowAdditiveTypeMapCreation = true;
        //        x.AddProfile(new GetAllManifestsQueryProfile());
        //    });

        //    mapperConfiguration.AssertConfigurationIsValid();
        //    return mapperConfiguration.CreateMapper();
        //}
    }
}