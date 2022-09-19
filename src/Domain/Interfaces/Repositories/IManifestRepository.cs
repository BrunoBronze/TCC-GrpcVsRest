using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manifest.Api.Domain.Interfaces.Repositories
{
    public interface IManifestRepository
    {
        Task<IEnumerable<Domain.Entities.Manifest>> GetAllManifestsAsync();
    }
}