using lifedashboard.Data;
using lifedashboard.Models;
using Microsoft.AspNetCore.Mvc;

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
            await dB.PresentLog.AddAsync(presentLog);
            await dB.SaveChangesAsync();
            return RedirectToAction("Index","Home");

           
        }
    }
}
