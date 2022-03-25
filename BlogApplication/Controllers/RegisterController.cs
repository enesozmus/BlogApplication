using BusinessLayer.Business.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace BlogApplication.Controllers
{
    public class RegisterController : Controller
    {
        AuthorManager authorManager = new AuthorManager(new EfAuthorRepository());

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Author author)
        {
            AuthorValidator authorValidator = new AuthorValidator();
            ValidationResult result = authorValidator.Validate(author);

            //if (result.IsValid && writer.WriterPassword == writer.WriterPasswordRepeat)
                if (result.IsValid)
                {
                    author.AuthorStatus = true;
                    author.AuthorAbout = "demo";
                    authorManager.Add(author);
                    return RedirectToAction("Index", "Blog");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                    }
                }
                return View();
        }
    }
}
