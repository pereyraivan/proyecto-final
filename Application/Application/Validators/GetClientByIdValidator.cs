using Application.Contracts;
using FluentValidation;

namespace Application.Validators
{
    public class GetClientByIdValidator : AbstractValidator<GetClientByIdRequest>
    {
        public GetClientByIdValidator()
        {
            RuleFor(obj => obj.Id)
           .NotNull().WithMessage("El ID no puede ser nulo.");
        }
    }
}
