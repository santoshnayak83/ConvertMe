using Microsoft.AspNetCore.Mvc;

namespace ConvertMe.Controllers
{
    public class PDFController : Controller
    {
        public IActionResult ImagetoPdf()
        {
            return View();
        }
        public IActionResult PdfMerger()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult PdfSplitter()
        {
            return View();
        }
    }
}
