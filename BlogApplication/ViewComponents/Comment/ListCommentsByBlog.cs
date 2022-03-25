using BusinessLayer.Business.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogApplication.ViewComponents.Comment
{
    public class ListCommentsByBlog : ViewComponent
    {
        CommentManager commentManager = new CommentManager(new EfCommentRepository());
        public IViewComponentResult Invoke(int id)
        {
            var comments = commentManager.GetAllComments(id);
            return View(comments);
        }
    }   
}
