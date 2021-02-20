using FluentValidation;
using DigitalBanking.Domain.Entities;

namespace DigitalBanking.Domain.Services.Validations
{
    public class EstadoValidator : AbstractValidator<Estado>
    {
        public EstadoValidator()
        {
            ValidateId();

            RuleSet("Insert", () =>
            {
            });

            RuleSet("Update", () =>
            {
                ValidateId();
            });
        }

        private void ValidateId()
        {
            RuleFor(o => o.Id).NotEmpty().WithMessage(Resources.Validations.IdRequired);
        }
    }
}
