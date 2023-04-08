using FluentValidation;
using HotelProject.WebUI.Dtos.GuestDto;

namespace HotelProject.WebUI.ValidationRules.GuestValidationRules
{
    public class CreateGuestValidator:AbstractValidator<CreateGuestDto>       //AbstactValidator`dan miras al. CreateGuestDto entity olarak gönder. Ekleme işlemi buradan oluyor çünkü
    {
        public CreateGuestValidator() 
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim Alanı Boş Geçilemez");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyisim Alanı Boş Geçilemez");
            RuleFor(x => x.City).NotEmpty().WithMessage("Şehir Alanı Boş Geçilemez");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("En Az 2 (iki) Karakter Veri Girişi Yapınız");
            RuleFor(x => x.Surname).MinimumLength(2).WithMessage("En Az 3 (üç) Karakter Veri Girişi Yapınız");
            RuleFor(x => x.City).MinimumLength(2).WithMessage("En Az 3 (üç) Karakter Veri Girişi Yapınız"); 
            RuleFor(x => x.Name).MaximumLength(20).WithMessage("En Fazla 20 (Yirmi) Karakter Veri Girişi Yapınız");
            RuleFor(x => x.Surname).MaximumLength(30).WithMessage("En Fazla 30 (Otuz) Karakter Veri Girişi Yapınız");
            RuleFor(x => x.City).MaximumLength(20).WithMessage("En Fazla 20 (Yirmi) Karakter Veri Girişi Yapınız");
            
           
        }


    }
}
