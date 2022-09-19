using MediatR;

namespace Manifest.Api.Domain.Queries.v1
{
    public class GetAllManifestsQuery : IRequest<GetAllManifestsQueryResponse>
    {
    }
}