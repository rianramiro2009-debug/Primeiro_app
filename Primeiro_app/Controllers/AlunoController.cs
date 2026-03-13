using Microsoft.AspNetCore.Mvc;

namespace Primeiro_app.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
