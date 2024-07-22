using Core_Proje1.Areas.Author.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje1.Areas.Author.Controllers
{
    [Area("Author")]
    [Route("Author/[controller]/[action]")]
    public class RegisterController : Controller
    {
        private readonly UserManager<User> userManager;
        public RegisterController(UserManager<User> userManager)
        {
            this.userManager = userManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserRegisterViewModel register)
        {
            if (ModelState.IsValid)
            {
                using (EntityLayer.Concrete.User newuser = new EntityLayer.Concrete.User())
                {
                    newuser.Name = register.Name;
                    newuser.Surname = register.Surname;
                    newuser.Email = register.Mail;
                    newuser.UserName = register.UserName;
                    newuser.imageUrl = register.ImageUrl;
                    var result = await userManager.CreateAsync(newuser, register.ConfirmPassword);
                    if(result.Succeeded)
                    {
                        return RedirectToAction("Index", "Login");
                    }
                    else
                    {
                        foreach (var item in result.Errors)
                        {
                            ModelState.AddModelError(item.Description, item.Code);
                        }
                    }
                }
            }
            return View(register);
        }
    }
}
