using lifedashboard.Data;
using Microsoft.AspNetCore.Mvc;

namespace lifedashboard.Controllers
{
    public class DashBoardController : Controller
    {
        private readonly DBConfig dB;
        public DashBoardController(DBConfig dB)
        {
            this.dB = dB;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
