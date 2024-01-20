using lifedashboard.Data;
using lifedashboard.Enums;
using lifedashboard.Models;
using lifedashboard.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace lifedashboard.Controllers
{
    public class AttendanceController : Controller
    {
        private readonly DBConfig dB;

        public AttendanceController(DBConfig dB)
        {
            this.dB = dB;
        }
        [HttpGet]
        public IActionResult Attendance()
        {
            return View();
        }

        [HttpPost]
        public async Task <IActionResult> Attendance(PresentLog log)
        {
            PresentLog presentLog = new PresentLog()
            {
                Id = Guid.NewGuid(),
                Phone=log.Phone,
                AttendDate = DateTime.Now,
                Month=DateTime.Now.ToString("MMMM"),
                CreateDate= DateTime.Now,
                LastModifiedDate= DateTime.Now
            };
            var checkPhone = await dB.MemberDetails.FirstOrDefaultAsync(x => x.Phone == presentLog.Phone);
            if (checkPhone != null) 
            {
                await dB.PresentLog.AddAsync(presentLog);
                await dB.SaveChangesAsync();
                return RedirectToAction("Index", "Home");
            }
            else
            {
             ViewBag.Alert= CommonServices.ShowAlert(Alerts.Info ,"Member not found. Please contact the GYM administrator");
            }

            return RedirectToAction("Index","Home");

           
        }

    }
}
