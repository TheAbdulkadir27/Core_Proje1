using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje1.Areas.Author.ViewComponents
{
    public class Navbar : ViewComponent
    {
        private readonly UserManager<User> _usermanager;
        public Navbar(UserManager<User> usermanager)
        {
            _usermanager = usermanager;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _usermanager.FindByNameAsync(User.Identity!.Name);
            ViewBag.V = values.imageUrl;
            return View();
        }
    }
}
