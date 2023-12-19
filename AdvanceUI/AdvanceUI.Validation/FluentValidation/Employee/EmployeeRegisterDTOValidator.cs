using AdvanceUI.DTOs.Employee;
using FluentValidation;

namespace AdvanceUI.Validation.FluentValidation.Employee
{
    public class EmployeeRegisterDTOValidator : AbstractValidator<EmployeeRegisterDTO>
    {
        public EmployeeRegisterDTOValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Ad alanı boş geçilemez.")
                .MaximumLength(50).WithMessage("Ad alanı en fazla 50 karakter olmalıdır.");

            RuleFor(x => x.Surname)
                .NotEmpty().WithMessage("Soyad alanı boş geçilemez.")
                .MaximumLength(50).WithMessage("Soyad alanı en fazla 50 karakter olmalıdır.");

            RuleFor(x => x.PhoneNumber)
                .NotEmpty().WithMessage("Telefon numarası alanı boş geçilemez.")
                .MaximumLength(15).WithMessage("Telefon numarası en fazla 15 karakter olmalıdır.");

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("E-posta adresi boş geçilemez.")
                .EmailAddress().WithMessage("Geçerli bir e-posta adresi giriniz.");

            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("Şifre alanı boş geçilemez.")
                .MinimumLength(6).WithMessage("Şifre en az 6 karakter olmalıdır.");

            RuleFor(x => x.PasswordConfirm)
                .Equal(x => x.Password).WithMessage("Şifreler uyuşmuyor.");

            RuleFor(x => x.BusinessUnitId)
                .NotEmpty().WithMessage("Bir birim seçiniz.")
                .GreaterThan(0).WithMessage("Geçerli bir birim seçiniz.");

            RuleFor(x => x.UpperEmployeeId)
                .NotEmpty().WithMessage("Bir üst çalışan seçiniz.")
                .GreaterThan(0).WithMessage("Geçerli bir üst çalışan seçiniz.");

            RuleFor(x => x.TitleId)
                .NotEmpty().WithMessage("Bir ünvan seçiniz.")
                .GreaterThan(0).WithMessage("Geçerli bir ünvan seçiniz.");
        }
    }
}
