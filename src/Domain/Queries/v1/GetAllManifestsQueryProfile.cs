using AutoMapper;
using Manifest.Api.Domain.Entities;

namespace Manifest.Api.Domain.Queries.v1
{
    public class GetAllManifestsQueryProfile : Profile
    {
        public GetAllManifestsQueryProfile()
        {
            CreateMap<Entities.Manifest, ManifestGetAllManifestsQueryResponse>();

            CreateMap<Flight, FlightGetAllManifestsQueryResponse>();
        }
    }
}