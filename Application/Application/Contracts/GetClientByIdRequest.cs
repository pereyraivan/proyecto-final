using MediatR;

namespace Application.Contracts
{
    public class GetClientByIdRequest : IRequest<GetClientByIdResponse>
    {
        public int Id { get; set; }
    }
}
