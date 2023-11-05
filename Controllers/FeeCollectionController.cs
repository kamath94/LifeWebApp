using lifedashboard.Data;
using lifedashboard.Models;
using Microsoft.AspNetCore.Mvc;

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
            try
            {
                FeeCollection feeCollection = new FeeCollection()
                {
                    Id = Guid.NewGuid(),
                    MemberId = 404,
                    Name = "404",
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
