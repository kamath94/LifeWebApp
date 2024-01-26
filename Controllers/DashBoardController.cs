using lifedashboard.Data;
using lifedashboard.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace lifedashboard.Controllers
{
    public class DashboardController : Controller
    {
        //private readonly DBConfig dB;
        //DateTime todaysDate = DateTime.Now;
        //DateTime yesterdaysDate = DateTime.Now.AddDays(-1);

        //public DashboardController(DBConfig dB)
        //{
        //    this.dB = dB;
        //}

        //[HttpGet]
        //public IActionResult Dashboard()
        //{
        //    var details = dB.MemberDetails.ToList();
        //    var presentToday = (from a in dB.PresentLog.Where(s => s.CreateDate > yesterdaysDate && s.CreateDate <= todaysDate) select a).ToList();
        //    int revenueYr = (int)(from fee in dB.FeeCollection select fee.FeeAmount).Sum();
        //    int revenueCntMonth = 800; //(int)(from fee in dB.FeeCollection.Where(s => s.CreateDate > yesterdaysDate && s.CreateDate <= todaysDate) select fee.FeeAmount).Sum();

        //    Dashboard dashboard = new Dashboard()
        //    {
        //        MemberCount = details.Count,
        //        memberPresentDay = presentToday.Count,
        //        revenueYear = revenueYr,
        //        revenueCurentMonth = revenueCntMonth,
        //    };



        //    return View(dashboard);
        //}
    }
}