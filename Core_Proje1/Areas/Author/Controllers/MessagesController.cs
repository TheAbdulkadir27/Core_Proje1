using BusinessLayer.Concrete;
using DataAccessLayer.Context;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
namespace Core_Proje1.Areas.Author.Controllers
{
    [Area("Author")]
    [Authorize]
    [Route("Author/Messages/")]
    public class MessagesController : Controller
    {
        AuthorMessageManager AuthorMessageManager = new AuthorMessageManager(new EfAuthorMessageDal(new DataAccessLayer.Context.DataBaseContext()));
        private readonly UserManager<User> _userManager;
        public MessagesController(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        [Route("")]
        [Route("ReceiverMessage")]
        public async Task<IActionResult> ReceiverMessage(string p)
        {
            var value = await _userManager.FindByNameAsync(User.Identity!.Name);
            p = value.Email;
            var messagelist = AuthorMessageManager.TGetListByFilter(x => x.Receiver == p);
            return View(messagelist);
        }
        [Route("")]
        [Route("SenderMessage")]
        public async Task<IActionResult> SenderMessage(string p)
        {
            var value = await _userManager.FindByNameAsync(User.Identity!.Name);
            p = value.Email;
            var messagelist = AuthorMessageManager.TGetListByFilter(x => x.Sender == p);
            return View(messagelist);
        }

        [Route("MessageDetails/{id}")]
        public IActionResult MessageDetails(int id)
        {
            AuthorMessage authorMessage = AuthorMessageManager.GetByID(id);
            return View(authorMessage);
        }
        [Route("ReceiverMessageDetails/{id}")]
        public IActionResult ReceiverMessageDetails(int id)
        {
            AuthorMessage authorMessage = AuthorMessageManager.GetByID(id);
            return View(authorMessage);
        }

        [HttpGet]
        [Route("")]
        [Route("SendMessage")]
        public IActionResult SendMessage()
        {
            return View();
        }
        [HttpPost]
        [Route("")]
        [Route("SendMessage")]
        public async Task<IActionResult> SendMessage(AuthorMessage author)
        {
            var value = await _userManager.FindByNameAsync(User.Identity!.Name);
            string mail = value.Email;
            string Name = value.Name + " " + value.Surname;
            author.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            author.Sender = mail;
            author.SenderName = Name;

            DataBaseContext dataBaseContext = new DataBaseContext();
            var usernamesurname = dataBaseContext.Users.Where(x => x.Email == author.Receiver).Select(y => y.Name + " " + y.Surname).FirstOrDefault();
            author.ReceiverName = usernamesurname!;
            AuthorMessageManager.TInsert(author);
            return RedirectToAction("SenderMessage");
        }
    }
}
