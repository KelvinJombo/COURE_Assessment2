using Assessment2.Application.Dtos;
using FluentValidation;
 

namespace Assessment2.Application.Validators
{   

    public class DecodeNumberRequestValidator : AbstractValidator<DecodeNumberRequest>
    {
        public DecodeNumberRequestValidator()
        {
            RuleFor(x => x.PhoneNumber)
                .NotEmpty().WithMessage("Phone number is required.")
                .MinimumLength(3).WithMessage("Phone number must be more than 3 digits.")
                .Matches(@"^\d+$")
                .WithMessage("Phone number must contain digits only (no letters or special characters).");
        }
    }

}
