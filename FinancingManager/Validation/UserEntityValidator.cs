using FinancingManager.Entities;
using FluentValidation;

namespace FinancingManager.Validation
{
    public class UserEntityValidator : AbstractValidator<UserEntity>
    {
        public UserEntityValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ім'я обов'язкове.");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("Прізвище обов'язкове.");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Ім'я користувача обов'язкове.");
            RuleFor(x => x.Email).NotEmpty().EmailAddress().WithMessage("Обов'язкова наявність дійсної адреси електронної пошти.");
            RuleFor(x => x.Password).NotEmpty().MinimumLength(8).WithMessage("Необхідно ввести пароль.");
        }
    }
}
