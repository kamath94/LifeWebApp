using Abp.Web.Mvc.Alerts;
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
                try
                {
                    await dB.PresentLog.AddAsync(presentLog);
                    await dB.SaveChangesAsync();
                    ViewBag.Type = "Success";
                    ViewBag.ErrorMessage ="Data is saved" ;
                    //return RedirectToAction("Index", "Home");
                    return View();
                }
                catch(Exception e)
                {
                    ViewBag.Type = "Error";
                    ViewBag.ErrorMessage =e;
                    return View();
                }
               

            } 
            else
            { 
                ViewBag.Type = "Warning";
                ViewBag.ErrorMessage ="Member not found. Please contact the GYM administrator";
              
                return View();
            }

           


        }

    }
}
