using Manifest.Api.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manifest.Api.Domain.Interfaces.Repositories
{
    public interface IFlightRepository
    {
        Task<IEnumerable<Flight>> GetAllManifestsAsync();
    }
}