using FluentValidation;

namespace Laconic.TestingValidation
{
    public class RegisterModelValidator : AbstractValidator<RegisterModel>
    {
        public RegisterModelValidator()
        {
            CascadeMode = CascadeMode.StopOnFirstFailure;

            RuleFor(x => x.Email).NotEmpty().EmailAddress().WithMessage("Please provide correct email");
            RuleFor(x => x.Password).NotEmpty().Length(8, 100);
            RuleFor(x => x.FirstName).NotEmpty();
            RuleFor(x => x.LastName).NotEmpty();
        }
    }
}