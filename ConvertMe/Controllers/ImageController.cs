using Microsoft.AspNetCore.Mvc;

namespace ConvertMe.Controllers
{
    public class ImageController : Controller
    {
        public IActionResult ImageCompressor()
        {
            return View();
        }
    }
}
