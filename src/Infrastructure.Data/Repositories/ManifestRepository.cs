using System.Collections.Generic;
using Dapper;
using Manifest.Api.Domain.Interfaces.Repositories;
using System.Data;
using System.Threading.Tasks;

namespace Manifest.Api.Infrastructure.Data.Repositories
{
    public class ManifestRepository : IManifestRepository
    {
        private readonly IDbConnection _connection;

        public ManifestRepository(IDbConnection sqlConnection)
        {
            _connection = sqlConnection;
        }

        public async Task<IEnumerable<Domain.Entities.Manifest>> GetAllManifestsAsync()
        {
            var sql = @"SELECT Id
                              ,ManifestKey
                              ,Json 
                        FROM Manifest";

            return await _connection.QueryAsync<Domain.Entities.Manifest>(sql, commandTimeout: 5);
        }
    }
}