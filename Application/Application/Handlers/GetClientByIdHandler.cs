using Application.Contracts;
using Domain.Interfaces;
using FluentValidation;
using MediatR;

namespace Application.Handlers
{
    public class GetClientByIdHandler : IRequestHandler<GetClientByIdRequest, GetClientByIdResponse>
    {
        private readonly IClientRepository _clientRepository;
        private readonly IValidator<GetClientByIdRequest> _validator;

        public GetClientByIdHandler(IClientRepository clientRepository, IValidator<GetClientByIdRequest> validator)
        {
            _clientRepository = clientRepository;
            _validator = validator;
        }

        public async Task<GetClientByIdResponse> Handle(GetClientByIdRequest request, CancellationToken cancellationToken)
        {
            var response = new GetClientByIdResponse();

            var result = _validator.Validate(request);

            if (!result.IsValid)
                throw new Exception();

            var client = _clientRepository.GetClientById(request.Id);
            response.client = client;
            return response;
        }
    }
    
}
