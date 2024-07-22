using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje1.Controllers
{
    public class AdminMessageController : Controller
    {
        AuthorMessageManager AuthorMessageManager = new AuthorMessageManager(new EfAuthorMessageDal(new DataAccessLayer.Context.DataBaseContext()));
        public IActionResult ReceiverMessageList()
        {
            string p = "abdulkadiryonucuoglu2727@gmail.com";
            var values = AuthorMessageManager.TGetListByFilter(x => x.Receiver == p);
            return View(values);
        }
        public IActionResult SenderMessageList()
        {
            string p = "abdulkadiryonucuoglu2727@gmail.com";
            var values = AuthorMessageManager.TGetListByFilter(x => x.Sender == p);
            return View(values);
        }
        public IActionResult AdminMessageDetails(int id) => View(AuthorMessageManager.GetByID(id));
    }
}
