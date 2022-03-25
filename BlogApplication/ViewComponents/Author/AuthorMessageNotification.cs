using Microsoft.AspNetCore.Mvc;

namespace BlogApplication.ViewComponents.Author
{
    public class AuthorMessageNotification : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
