using lifedashboard.Data;
using lifedashboard.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuGet.Packaging.Signing;

namespace lifedashboard.Controllers
{
    public class FeeCollectionController : Controller
    {
        private readonly DBConfig dB;

        public FeeCollectionController(DBConfig dB)
        {
            this.dB = dB;
        }

        [HttpGet]
        public IActionResult FeeCollection()
        {
            return View();
        }


        [HttpPost]
        public async Task <IActionResult> FeeCollection(FeeCollection collection)
        {
          //Issue // var memberdetail = await dB.MemberDetails.FindAsync(collection.Phone);
        

            try
            {
                FeeCollection feeCollection = new FeeCollection()
                {
                    Id = Guid.NewGuid(),
                    MemberId = 404,// int.Parse(memberdetail.Id.ToString()),
                    Name = "404",//memberdetail.Name,
                    Phone = collection.Phone,
                    FeeType = collection.FeeType,
                    FeeAmount = collection.FeeAmount,
                    DateOfPayment = collection.DateOfPayment,
                    Instructors = collection.Instructors,
                    CreateDate = DateTime.Now,
                    LastModifiedDate = DateTime.Now


                };
                await dB.FeeCollection.AddRangeAsync(feeCollection);
                await dB.SaveChangesAsync();
                return View("FeeCollection");
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex;
                return View("FeeCollection");
            }
           
        }
    }
}
