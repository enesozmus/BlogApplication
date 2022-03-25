using BusinessLayer.Business.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogApplication.Controllers
{
    public class AboutController : Controller
    {
        AboutManager aboutManager = new AboutManager(new EfAboutRepository());

        public IActionResult Index()
        {
            var result = aboutManager.GetAll();
            
            return View(result);
        }

        public PartialViewResult SocialMediaAbout()
        {
            return PartialView();
        }
    }
}
