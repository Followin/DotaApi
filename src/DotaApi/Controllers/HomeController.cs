using Microsoft.AspNet.Mvc;

namespace DotaApi.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return File("~/index.html", "text/html");
        }
    }
}
