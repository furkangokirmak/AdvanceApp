using AdvanceUI.DTOs.Advance;
using FluentValidation;
using System;

namespace AdvanceUI.Validation.FluentValidation.Advance
{
    public class AdvanceInsertDTOValidator : AbstractValidator<AdvanceInsertDTO>
    {
        public AdvanceInsertDTOValidator()
        {
            RuleFor(x => x.AdvanceAmount)
                .NotNull().WithMessage("Avans miktarı boş bırakılamaz.")
                .GreaterThan(0).WithMessage("Avans miktarı 0'dan büyük olmalıdır.")
                .Must(x => x % 1 == 0).WithMessage("Avans miktarı tam sayı olmalıdır.")
                .LessThanOrEqualTo(500000).WithMessage("Avans miktarı 500,000 TL'den fazla olamaz.");

            RuleFor(x => x.AdvanceDescription)
                .NotEmpty().WithMessage("Avans açıklaması boş bırakılamaz.")
                .MaximumLength(100).WithMessage("Avans açıklaması en fazla 100 karakter olmalıdır.");

            RuleFor(x => x.ProjectId)
                .NotNull().WithMessage("Proje seçmelisiniz.");

            RuleFor(x => x.DesiredDate)
                .NotNull().WithMessage("Tarih boş bırakılamaz.")
                .Must(BeAValidDate).WithMessage("Geçmiş bir tarih seçemezsiniz.");
        }

        private bool BeAValidDate(DateTime? date)
        {
            return date.HasValue && date >= DateTime.Today;
        }
    }
}
