
using Application.Contracts;
using Application.Handlers;
using AutoMapper;
using Domain.Interfaces;
using FluentValidation;
using Moq;
using NUnit.Framework;
using Xunit;

namespace ProjecTests
{

    public class GetClientByIdHandlerTest
    {

        private readonly Mock<IMapper> _mapper;
        private readonly Mock<IClientRepository> _clientRepository;
        private readonly Mock<IValidator<GetClientByIdRequest>> _validator;

        private GetClientByIdHandler handler;
        public GetClientByIdHandlerTest()
        {
            var result = new FluentValidation.Results.ValidationResult();
            _validator = new Mock<IValidator<GetClientByIdRequest>>();
            _validator
                .Setup(validator => validator.Validate(It.IsAny<GetClientByIdRequest>()))
                .Returns(result);

            _clientRepository = new Mock<IClientRepository>();
            _clientRepository.Setup(repository => repository.GetClients());



            handler = new GetClientByIdHandler(_clientRepository.Object, _validator.Object);
        }
        [Fact]
        public void valido_ResponseValido()
        {
            Assert.True(false, "Esta prueba debería fallar");
        }
    }
}