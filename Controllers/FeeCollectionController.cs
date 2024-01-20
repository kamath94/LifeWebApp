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
            //Issue // var memberdetail = await dB.MemberDetails.FindAsync(collection.Phone);

            IEnumerable <string>  name = from i in dB.MemberDetails where i.Phone == collection.Phone select i.Name;
            IEnumerable <Guid> id = from i in dB.MemberDetails where i.Phone == collection.Phone select i.Id;
            try
            {
                FeeCollection feeCollection = new FeeCollection()
                {
                    Id = Guid.NewGuid(),
                    //MemberId =int.Parse(id.First()),
                    Name = name.First(),
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
                return RedirectToAction("Index", "Home");
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex;
                return RedirectToAction("Index", "Home");
            }
           
        }
    }
}
