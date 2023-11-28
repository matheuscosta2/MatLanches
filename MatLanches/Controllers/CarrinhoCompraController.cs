using Microsoft.AspNetCore.Mvc;

namespace MatLanches.Controllers
{
    public class CarrinhoCompraController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
