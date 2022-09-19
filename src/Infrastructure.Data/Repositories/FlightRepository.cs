using Dapper;
using Manifest.Api.Domain.Entities;
using Manifest.Api.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Manifest.Api.Infrastructure.Data.Repositories
{
    public class FlightRepository : IFlightRepository
    {
        private readonly IDbConnection _connection;

        public FlightRepository(IDbConnection sqlConnection)
        {
            _connection = sqlConnection;
        }

        public async Task<IEnumerable<Flight>> GetAllManifestsAsync()
        {
            var sql = @"SELECT Id
                              ,FlightKey
                              ,ManifestKey
                              ,Json 
                        FROM Flight";

            return await _connection.QueryAsync<Flight>(sql);
        }
    }
}