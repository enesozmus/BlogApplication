using BusinessLayer.Business.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogApplication.ViewComponents.Blog
{
    public class LastThreeBlogs : ViewComponent
    {
        BlogManager _blogManager = new BlogManager(new EfBlogRepository());

        public IViewComponentResult Invoke()
        {
            var threeBlogs = _blogManager.GetLastThreeBlogs();
            return View(threeBlogs);
        }
    }
}
