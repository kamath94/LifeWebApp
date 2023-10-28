using lifedashboard.Data;
using lifedashboard.Models;
using Microsoft.AspNetCore.Mvc;

namespace lifedashboard.Controllers
{
    public class MembershipController : Controller
    {
        DBUtil dB=new DBUtil();
        Members members = new Members();

        public IActionResult Membership()
        {
            return View();
        }

        public void 

    }
}
