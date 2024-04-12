using FinancingManager.Entities;
using FinancingManager.Models;
using FluentValidation;

namespace FinancingManager.Validation
{
    internal class RegisterModelValidator : AbstractValidator<UserEntity>
    {
        public RegisterModelValidator()
        { 
            RuleFor(x => x.Email).NotEmpty().WithMessage("Обов'язкове поле");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Обов'язкове поле").MinimumLength(8).WithMessage("Мінімальна довжина 8 символів");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Обов'язкове поле").MaximumLength(20).WithMessage("Нікнейм завеликий");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("Обов'язкове поле");
            RuleFor(x => x.Name).NotEmpty().WithMessage("Обов'язкове поле");
        }
    }
}
