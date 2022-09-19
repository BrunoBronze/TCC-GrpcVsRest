using AutoMapper;
using Manifest.Api.Domain.Interfaces.Repositories;
using MediatR;
using Newtonsoft.Json;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Manifest.Api.Domain.Queries.v1
{
    public class GetAllManifestsQueryHandler : IRequestHandler<GetAllManifestsQuery, GetAllManifestsQueryResponse>
    {
        private readonly IMapper _mapper;
        private readonly IManifestRepository _manifestRepository;
        private readonly IFlightRepository _flightRepository;

        public GetAllManifestsQueryHandler(IMapper mapper, IManifestRepository manifestRepository, IFlightRepository flightRepository)
        {
            _mapper = mapper;
            _manifestRepository = manifestRepository;
            _flightRepository = flightRepository;
        }

        public async Task<GetAllManifestsQueryResponse> Handle(GetAllManifestsQuery request, CancellationToken cancellationToken)
        {
            var manifests = await _manifestRepository.GetAllManifestsAsync();
            var flights = await _flightRepository.GetAllManifestsAsync();

            return new GetAllManifestsQueryResponse
            {
                Manifests = manifests.Select(manifest => JsonConvert.DeserializeObject<ManifestGetAllManifestsQueryResponse>(manifest.Json)),
                Flights = flights.Select(flight => JsonConvert.DeserializeObject<FlightGetAllManifestsQueryResponse>(flight.Json))
            };
        }
    }
}