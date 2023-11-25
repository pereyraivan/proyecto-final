using Application.Contracts;
using Application.Models;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using FluentValidation;
using MediatR;

namespace Application.Handlers
{
    public class GetClientHandler : IRequestHandler<GetClientRequest, GetClientResponse>
    {
        private readonly IMapper _mapper;
        private readonly IClientRepository _clientRepository;
        private readonly IValidator<GetClientRequest> _validator;

        public GetClientHandler(IClientRepository clientRepository, IValidator<GetClientRequest> validator,IMapper mapper)
        {
            _clientRepository = clientRepository;
            _validator = validator;
            _mapper = mapper;
        }
        public async Task<GetClientResponse> Handle(GetClientRequest request, CancellationToken cancellationToken)
        {
            var response = new GetClientResponse();
          
            var result = _validator.Validate(request);

            
            var clientList = _clientRepository.GetClients();
            response.ClientList = clientList.Select(MapTo).ToList();
            return response;
        }

        private ClientDto MapTo(Client client)
        {
            return _mapper.Map<ClientDto>(client);
        }
    }
}
