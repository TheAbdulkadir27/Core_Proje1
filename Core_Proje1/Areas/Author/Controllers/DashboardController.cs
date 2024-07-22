using DataAccessLayer.Context;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace Core_Proje1.Areas.Author.Controllers
{
    [Area("Author")]
    [Authorize]
    public class DashboardController : Controller
    {
        private readonly UserManager<User> _usermanager;
        public DashboardController(UserManager<User> usermanager) => _usermanager = usermanager;
        public async Task<IActionResult> Index()
        {
            var value = await _usermanager.FindByNameAsync(User.Identity!.Name);
            ViewBag.V = value.Name + " " + value.Surname;
            using (DataBaseContext context = new DataBaseContext())
            {
                ViewBag.V1 = context.AuthorMessages.Where(X => X.Receiver == value.Email).Count();
                ViewBag.V2 = context.Announcements.Count();
                ViewBag.V3 = context.Users.Count();
                ViewBag.V4 = context.Skills.Count();

                string api = "10501a074e1c94e644ea41a6ef6542a9";
                string connection = "https://api.openweathermap.org/data/2.5/weather?q=gaziantep&mode=xml&lang=tr&units=metric&&appid=" + api;
                XDocument xDocument = XDocument.Load(connection);
                ViewBag.V5 = xDocument.Descendants("temperature").ElementAt(0).Attribute("value")!.Value;
            }
            return View();
        }
    }
}
