using FluentValidation;
using my_vue_starter_new.ViewModel;
 

namespace my_vue_starter_new.ViewModels.Validations
{
    public class RegistrationViewModelValidator : AbstractValidator<RegistrationViewModel>
    {
        public RegistrationViewModelValidator()
        {
            RuleFor(vm => vm.Email).NotEmpty().WithMessage("Email cannot be empty");
            RuleFor(vm => vm.Password).NotEmpty().WithMessage("Password cannot be empty");
            RuleFor(vm => vm.FullName).NotEmpty().WithMessage("FirstName cannot be empty");
            RuleFor(vm => vm.Birthdate).NotEmpty().WithMessage("Location cannot be empty");
        }
    }
}