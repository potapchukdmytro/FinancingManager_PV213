using FinancingManager.Models;
using FluentValidation;

namespace FinancingManager.Validation
{
    public class LoginModelValidator : AbstractValidator<LogInModel>
    {
        public LoginModelValidator()
        {
            RuleFor(x => x.Login).NotEmpty().WithMessage("Обов'язкове поле");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Необхідно ввести пароль.").MinimumLength(8).WithMessage("Мінімальна довжина 8 символів");
        }
    }
}
