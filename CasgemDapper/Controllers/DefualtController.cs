using Microsoft.AspNetCore.Mvc;

namespace CasgemDapper.Controllers
{
    public class DefualtController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
