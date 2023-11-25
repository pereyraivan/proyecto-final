using Application.Contracts;
using Application.Handlers;
using Application.Models;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using FluentValidation;
using FluentValidation.Results;
using Moq;
using Xunit;

namespace TestProject1
{
    public class GetClientHandlerTests
    {

        private readonly Mock<IMapper> _mapper;
        private readonly Mock<IClientRepository> _clientRepository;
        private readonly Mock<IValidator<GetClientRequest>> _validator;

        private GetClientHandler handler;
        public GetClientHandlerTests()
        {
            var result = new ValidationResult();

            var listaClientes = new List<Client>
            {
                new Client { id_cliente = 1, nombre = "Juan",provincia = "Tucuman", ciudad ="Famailla", direccion="Alem124",zona = "Centro" },
                new Client { id_cliente = 1, nombre = "Pedro",provincia = "Santa Fe", ciudad ="Rosario", direccion="Roca 34",zona = "Centro"},
                
            };
            var listaClientesDto = new ClientDto 
            {
                  id_cliente = 1,nombre = "Juan",provincia = "Tucuman", ciudad ="Famailla", zona = "Centro" 
                 
            };

            _validator = new Mock<IValidator<GetClientRequest>>();
            _validator
                .Setup(validator => validator.Validate(It.IsAny<GetClientRequest>()))
                .Returns(result);

            _clientRepository = new Mock<IClientRepository>();
            _clientRepository.Setup(repository => repository.GetClients())
                .Returns(listaClientes);

            _mapper = new Mock<IMapper>();
            _mapper.Setup(m => m.Map<ClientDto>(It.IsAny<Client>))
                .Returns(listaClientesDto);
                      

            handler = new GetClientHandler(_clientRepository.Object, _validator.Object, _mapper.Object);
        }
        [Fact]
        public async void valido_ResponseValido()
        {
            var response = await handler.Handle(new GetClientRequest(), CancellationToken.None);

            Assert.NotNull(response);
        }
    }
}