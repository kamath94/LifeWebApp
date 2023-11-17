using lifedashboard.Data;
using lifedashboard.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace lifedashboard.Controllers
{
    public class DashboardController : Controller
    {
        private readonly DBConfig dB;

        public DashboardController(DBConfig dB)
        {
            this.dB = dB;
        }

        [HttpGet]
        public async Task<IActionResult> Dashboard()
        {
            var details = await dB.MemberDetails.ToListAsync();
            int membercount = details.Count;
            var dashboard = new Dashboard();
            dashboard.MemberCount = membercount;

            dashboard.revenueYear = 0;
            var fee = await dB.FeeCollection.ToListAsync();
            foreach (var item in fee)
            {
                dashboard.revenueYear = (int)(dashboard.revenueYear + item.FeeAmount);
            }

            return View(dashboard);
        }
    }
}