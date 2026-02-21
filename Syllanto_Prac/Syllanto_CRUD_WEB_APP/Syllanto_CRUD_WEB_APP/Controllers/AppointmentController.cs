using Microsoft.AspNetCore.Mvc;

namespace Syllanto_CRUD_WEB_APP.Controllers
{
    public class AppointmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CreateNew()
        {
            return View();
        }
    }
}
