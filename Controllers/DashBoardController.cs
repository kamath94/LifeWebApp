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
        public IActionResult Dashboard(Dashboard dash)
        {
            var currentYear = DateTime.Now.Year;
            var currentMonth = DateTime.Now.Month;

            dash.TotalMember = "Hello"; //dB.MemberDetails.Count().ToString();
            dash.TotalRevenue = dB.FeeCollection.Sum(s => s.FeeAmount).ToString();
            dash.RevenueCurrentYear = dB.FeeCollection.Where(fee => fee.CreateDate.Value.Year == currentYear).Sum(s => s.FeeAmount).ToString();
            dash.RevenueCurrentMonth = dB.FeeCollection.Where(fee => fee.CreateDate.Value.Month == currentMonth).Sum(s => s.FeeAmount).ToString();
            dash.MemberVisitedCurrentMonth = dB.PresentLog.Where(log => log.CreateDate.Value.Month == currentMonth).Select(log => log.Phone).Distinct().Count().ToString();
            dash.MemberVisitedToday = dB.PresentLog.Where(log => log.CreateDate.Value == DateTime.Now).Select(log => log.Phone).Distinct().Count().ToString();
            dash.NewAdmissionCurrentMonth = dB.MemberDetails.Where(x => x.CreateDate.Value.Month == currentMonth).Select(x => x.Name).ToString();

            return View(dash);

        }
    }
}