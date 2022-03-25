using BusinessLayer.Business.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogApplication.ViewComponents.Blog
{
    public class AuthorsLastBlog : ViewComponent
    {
        BlogManager _blogManager = new BlogManager(new EfBlogRepository());

        public IViewComponentResult Invoke()
        {
            var blogs = _blogManager.GetBlogListByAuthor(1);        // under dev.
            return View(blogs);
        }
    }
}
