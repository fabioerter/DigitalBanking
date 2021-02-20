using FluentValidation;
using DigitalBanking.Domain.Entities;

namespace DigitalBanking.Domain.Services.Validations
{
    public class FuncionarioValidator : AbstractValidator<Funcionario>
    {
        public FuncionarioValidator()
        {
            ValidateId();

            RuleSet("Insert", () => { });

            RuleSet("Update", () => { ValidateId(); });
        }

        private void ValidateId()
        {
            RuleFor(o => o.Id).NotEmpty().WithMessage(Resources.Validations.IdRequired);
        }
    }
}
