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
            var currentDay = DateTime.Now.Day;

            dash.TotalMember = dB.MemberDetails.Count().ToString();
            dash.TotalRevenue = dB.FeeCollection.Sum(s => s.FeeAmount).ToString();
            dash.RevenueCurrentYear = dB.FeeCollection.Where(fee => fee.CreateDate.Year == currentYear).Sum(s => s.FeeAmount).ToString();
            dash.RevenueCurrentMonth = dB.FeeCollection.Where(m => m.CreateDate.Year == currentYear && m.CreateDate.Month == currentMonth).Sum(s => s.FeeAmount).ToString();

            dash.RevenueCurrentDay = dB.FeeCollection.Where(m => m.CreateDate.Year == currentYear && m.CreateDate.Month == currentMonth && m.CreateDate.Day == currentDay).Sum(s => s.FeeAmount).ToString();

            dash.MemberVisitedCurrentMonth = dB.PresentLog.Where(m => m.CreateDate.Year == currentYear && m.CreateDate.Month == currentMonth).Select(log => log.Phone).Distinct().Count().ToString();
           
            dash.MemberVisitedToday = dB.PresentLog.
                Where(m => m.CreateDate.Year == currentYear && m.CreateDate.Month == currentMonth && m.CreateDate.Day == currentDay)
                .Select(log => log.Phone)
                .Distinct()
                .Count()
                .ToString();

            dash.NewAdmissionCurrentMonth = dB.MemberDetails.Where(m => m.CreateDate.Year == currentYear && m.CreateDate.Month == currentMonth).Count().ToString(); 

            return View(dash);

        }
    }
}