using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using EntityLayer.Concrete;
using Core_Proje1.Areas.Author.Models;
using Microsoft.AspNetCore.Authorization;
namespace Core_Proje1.Areas.Author.Controllers
{
    [Area("Author")]
    [Authorize]
    [Route("Author/[controller]/[action]")]
    public class ProfileController : Controller
    {
        private readonly UserManager<User> _userManager;
        public ProfileController(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var value = await _userManager.FindByNameAsync(User.Identity!.Name);
            UserEditViewModel userEditViewModel = new UserEditViewModel();
            userEditViewModel.Name = value.Name;
            userEditViewModel.Surname = value.Surname;
            userEditViewModel.PictureUrl = value.imageUrl;
            return View(userEditViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserEditViewModel user)
        {
            var user1 = await _userManager.FindByNameAsync(User.Identity!.Name);
            if (user.Picture != null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extention = Path.GetExtension(user.Picture.FileName);
                var imagename = Guid.NewGuid() + extention;
                var savelocation = resource + "/wwwroot/userimage/" + imagename;
                var stream = new FileStream(savelocation, FileMode.Create);
                await user.Picture.CopyToAsync(stream);
                user1.imageUrl = imagename;
            }
            user1.Name = user.Name;
            user1.Surname = user.Surname;
            user1.PasswordHash = _userManager.PasswordHasher.HashPassword(user1, user.Password);
            var result = await _userManager.UpdateAsync(user1);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Default");
            }
            return View();
        }
    }
}
