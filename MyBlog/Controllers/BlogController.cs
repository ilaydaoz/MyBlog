using BusinessLayer.Concrete;
using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace MyBlog.Controllers
{
    public class BlogController : Controller
    {
        private readonly IAboutService _blogService; 
        public BlogController(IAboutService blogService)
        {
            _blogService = blogService;
        }
        public IActionResult Index()
        {
            var values = _blogService.GetList();
            return View(values);
        }
    }
}
