using lifedashboard.Data;
using lifedashboard.Models;
using Microsoft.AspNetCore.Mvc;

namespace lifedashboard.Controllers
{
    public class MemberShipController : Controller
    {
        private readonly DBConfig db;

        public MemberShipController(DBConfig Db)
        {
            db = Db;
        }

        [HttpGet]
        public IActionResult MemberShip()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> MemberShip(MembeDetails addMember)
        {
            try
            {
                var MembeDetails = new MembeDetails()
                {
                    Id = Guid.NewGuid(),
                    Name = addMember.Name,
                    Age = addMember.Age,
                    Dob = addMember.Dob,
                    FatherName = addMember.FatherName,
                    FullAddress = addMember.FullAddress,
                    Phone = addMember.Phone,
                    Email = addMember.Email,
                    EmergencyNumber = addMember.EmergencyNumber,
                    Relation = addMember.Relation,
                    JoiningDate = addMember.JoiningDate,
                    Gender = addMember.Gender,
                    MaritalStatus = addMember.MaritalStatus,
                    Bloodgrp = addMember.Bloodgrp,
                    Height = addMember.Height,
                    Weight = addMember.Weight,
                    Timing = addMember.Timing,
                    Job = addMember.Job,
                    Qualification = addMember.Qualification,
                    IsActive = 1,
                    CreateDate = DateTime.Now,
                    LastModifiedDate = DateTime.Now
                };
                await db.MemberDetails.AddAsync(MembeDetails);
                await  db.SaveChangesAsync();
                return RedirectToAction("ListMember", "ListMember");
            }
            catch (Exception ex)
            {
                ViewBag.ErrorInfo = ex.Message;
                return View();
            }
            

            
        }
    }
}
