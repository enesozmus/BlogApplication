using Microsoft.AspNetCore.Mvc;

namespace BlogApplication.ViewComponents.Author
{
    public class AuthorAnnouncementNotification : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
