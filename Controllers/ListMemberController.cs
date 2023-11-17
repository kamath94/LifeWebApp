using lifedashboard.Data;
using lifedashboard.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;

namespace lifedashboard.Controllers
{
    public class ListMemberController : Controller
    {
        private readonly DBConfig dB;

        public ListMemberController(DBConfig dB)
        {
            this.dB = dB;
        }

        [HttpGet]
        public async Task<IActionResult> ListMember()
        {
            var details = await dB.MemberDetails.ToListAsync();
            return View(details);
        }

        [HttpGet]
        public async Task<IActionResult> ViewMember(Guid Id)
        {
            var singleMember = await dB.MemberDetails.FirstOrDefaultAsync(x => x.Id == Id);
            if (singleMember != null)
            {
                var memberdetail = new ViewDetails()
                {
                    Id = singleMember.Id,
                    Name = singleMember.Name,
                    Age = singleMember.Age,
                    Dob = singleMember.Dob,
                    FatherName = singleMember.FatherName,
                    FullAddress = singleMember.FullAddress,
                    Phone = singleMember.Phone,
                    Email = singleMember.Email,
                    EmergencyNumber = singleMember.EmergencyNumber,
                    Relation = singleMember.Relation,
                    JoiningDate = singleMember.JoiningDate,
                    Gender = singleMember.Gender,
                    MaritalStatus = singleMember.MaritalStatus,
                    Bloodgrp = singleMember.Bloodgrp,
                    Height = singleMember.Height,
                    Weight = singleMember.Weight,
                    Timing = singleMember.Timing,
                    Job = singleMember.Job,
                    Qualification = singleMember.Qualification,
                    IsActive = 1,
                    CreateDate = DateTime.Now,
                    LastModifiedDate = DateTime.Now
                };

                return View(memberdetail);
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ViewMember(ViewDetails details)
        {
            var memberdetail = await dB.MemberDetails.FindAsync(details.Id);
            if (memberdetail != null)
            {

                memberdetail.Name = details.Name;
                memberdetail.Age = details.Age;
                memberdetail.Dob = details.Dob;
                memberdetail.FatherName = details.FatherName;
                memberdetail.FullAddress = details.FullAddress;
                memberdetail.Phone = details.Phone;
                memberdetail.Email = details.Email;
                memberdetail.EmergencyNumber = details.EmergencyNumber;
                memberdetail.Relation = details.Relation;
                memberdetail.JoiningDate = details.JoiningDate;
                memberdetail.Gender = details.Gender;
                memberdetail.MaritalStatus = details.MaritalStatus;
                memberdetail.Bloodgrp = details.Bloodgrp;
                memberdetail.Height = details.Height;
                memberdetail.Weight = details.Weight;
                memberdetail.Timing = details.Timing;
                memberdetail.Job = details.Job;
                memberdetail.Qualification = details.Qualification;
                memberdetail.IsActive = details.IsActive;
                memberdetail.CreateDate = details.CreateDate;
                memberdetail.LastModifiedDate = details.LastModifiedDate;
                await dB.SaveChangesAsync();

                return RedirectToAction("ListMember", "ListMember");
            }
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> DeleteMember(ViewDetails details)
        {
            var memberdetail = await dB.MemberDetails.FindAsync(details.Id);
            if(memberdetail!=null)
            {
                dB.MemberDetails.Remove(memberdetail);
                await dB.SaveChangesAsync();
                return RedirectToAction("ListMember", "ListMember");
            }
            else { return RedirectToAction("ListMember", "ListMember"); } 
        }
    }
}