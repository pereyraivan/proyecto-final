using Application.Contracts;
using Domain.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("/api/clients")]
    public class ClientController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ClientController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetClients()
        {
            var request = new GetClientRequest();
            var response = await _mediator.Send(request);
            return Ok(response);
        }
        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetClientById([FromQuery] GetClientByIdRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}
