﻿using AdvanceUI.DTOs.Advance;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceUI.Validation.FluentValidation.Advance
{
    public class AdvanceInsertDTOValidator : AbstractValidator<AdvanceInsertDTO>
    {
        public AdvanceInsertDTOValidator()
        {
            RuleFor(x => x.AdvanceAmount)
                .NotNull().WithMessage("Avans miktarı boş bırakılamaz.")
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