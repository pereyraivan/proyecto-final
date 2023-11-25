using MediatR;

namespace Application.Contracts
{

    public class GetClientRequest : IRequest<GetClientResponse>
    {
        public string? Nombre { get; set; }
    }
}
