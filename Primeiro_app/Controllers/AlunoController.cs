using Microsoft.AspNetCore.Mvc;

namespace Primeiro_app.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.nota = "Aluno nota 10";
            ViewData["Escola"] = "E.E Anhanguera";
            return View();
        }

        public IActionResult Teste()
        {
            TempData["MSG_EX"] = "Mensagem do TemData";
            return RedirectToAction("Resultado");
        }
        public IActionResult Resultado()
        {
            if (TempData["MSG_EX"] != null)
                ViewBag.Exemplo = "Aluno ETEC MB";
            return View();
        }
    }
}