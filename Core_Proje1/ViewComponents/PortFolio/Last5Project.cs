using Microsoft.AspNetCore.Mvc;

namespace Core_Proje1.ViewComponents.PortFolio
{
    public class Last5Project : ViewComponent
    {
        public IViewComponentResult Invoke() => View();
    }
}
