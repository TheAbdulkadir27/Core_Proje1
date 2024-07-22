using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje1.ViewComponents.Feature
{
    public class ToDoListPanel : ViewComponent
    {
        ToDoListManager ToDoListManager = new ToDoListManager(new EfToDoListDal(new DataAccessLayer.Context.DataBaseContext()));
        public IViewComponentResult Invoke() => View(ToDoListManager.TGetList());
    }
}
