using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
namespace Core_Proje1.ViewComponents.Feature
{
    public class MessageList : ViewComponent
    {
        UserMessageManager UserMessageManager = new UserMessageManager(new EfUserMessageDal(new DataAccessLayer.Context.DataBaseContext()));
        public IViewComponentResult Invoke()
        {
            return View(UserMessageManager.GetUserMessagesWithUserService());
        }
    }
}
