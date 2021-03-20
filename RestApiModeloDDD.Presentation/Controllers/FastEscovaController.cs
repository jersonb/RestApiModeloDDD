using Microsoft.AspNetCore.Mvc;

namespace RestApiModeloDDD.Presentation.Controllers
{
    public class FastEscovaController : Controller
    {
        public IActionResult RespostasHTML()
        {
            return View();
        }
        public IActionResult RespostasSQL()
        {
            return View();
        }
        public IActionResult RespostasTeoricas()
        {
            return View();
        }
        public IActionResult RespostasLogicas()
        {
            return View();
        }
    }
}
