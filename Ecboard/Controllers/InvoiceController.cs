using Microsoft.AspNetCore.Mvc;

namespace Ecboard.Controllers
{
    public class InvoiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult PrintInvoice()
        {
            return View();
        }
    }
}
