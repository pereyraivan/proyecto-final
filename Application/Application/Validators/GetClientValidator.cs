using Application.Contracts;
using FluentValidation;

namespace Application.Validators
{
    public class GetClientValidator : AbstractValidator<GetClientRequest>
    {
        public GetClientValidator() 
        {
            RuleFor(x => x.Nombre).Matches("^[a-zA-Z]+$").WithMessage("El nombre solo puede contener letras");
        }
    }
}
