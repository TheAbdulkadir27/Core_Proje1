using Microsoft.AspNetCore.Mvc;
namespace Core_Proje1.ViewComponents.Contact
{
    public class SendMessage : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
