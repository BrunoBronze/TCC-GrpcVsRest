using Grpc.Core;
using Manifest.Api.Grpc.protos;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace Manifest.Api.Grpc.Services
{
    public class ManifestService : ManifestGrpc.ManifestGrpcBase
    {
        private readonly ILogger<ManifestService> _logger;

        public ManifestService(ILogger<ManifestService> logger)
        {
            _logger = logger;
        }

        public override Task<GetAllFlightsAndManifestsResponse> GetAllFlightsAndManifests(GetAllFlightsAndManifestsRequest request, ServerCallContext context)
        {
            return Task.FromResult(new GetAllFlightsAndManifestsResponse
            {
                Message = "Hello " + request.Name
            });
        }
    }
}