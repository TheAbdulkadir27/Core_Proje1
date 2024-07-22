using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class PortFolioValidator : AbstractValidator<PortFolio>
    {
        public PortFolioValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Proje Adı Boş Geçilemez");
            RuleFor(x => x.Image1).NotEmpty().WithMessage("Görsel Alanı Boş Geçilemez");
            RuleFor(x => x.Image2).NotEmpty().WithMessage("Görsel 2 Alanı Boş Geçilemez");
            RuleFor(x => x.ProjectUrl).NotEmpty().WithMessage("Project Url Alanı Boş Geçilemez");
            RuleFor(x => x.Name).MinimumLength(5).WithMessage("Proje Adı en az 5 karakter olmalıdır");
        }
    }
}
