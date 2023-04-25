using FluentValidation;
using HotelProject.WebUI.Dtos.GuestDto;

namespace HotelProject.WebUI.ValidationRules.GuestValidationRules
{
    public class UpdateGuestValidator : AbstractValidator<UpdateGuestDto>
    {
        public UpdateGuestValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim alanı boş olamaz");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyisim alanı boş olamaz");
            RuleFor(x => x.City).NotEmpty().WithMessage("Soyisim alanı boş olamaz");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("İsim en az 3 karakter olmalı.");
            RuleFor(x => x.Surname).MinimumLength(2).WithMessage("İsim en az 2 karakter olmalı.");
            RuleFor(x => x.City).MinimumLength(3).WithMessage("İsim en az 3 karakter olmalı.");
            RuleFor(x => x.Name).MaximumLength(30).WithMessage("İsim en fazla 30 karakter olmalı.");
            RuleFor(x => x.Surname).MaximumLength(20).WithMessage("İsim en fazla 30 karakter olmalı.");
            RuleFor(x => x.City).MaximumLength(30).WithMessage("İsim en fazla 30 karakter olmalı.");
        }
    }
}
