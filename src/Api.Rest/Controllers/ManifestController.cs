using System;
using Manifest.Api.Domain.Queries.v1;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Net;
using System.Threading.Tasks;

namespace Manifest.Api.Rest.Controllers
{
    [ApiController]
    [Route("api/v1/manifests")]
    public class ManifestController : ControllerBase
    {
        private readonly ILogger<ManifestController> _logger;
        private readonly IMediator _mediator;

        public ManifestController(ILogger<ManifestController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpGet]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetAllManifests()
        {
            try
            {
                return StatusCode((int)HttpStatusCode.OK, new
                {
                    data = await _mediator.Send(new GetAllManifestsQuery())
                });
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}