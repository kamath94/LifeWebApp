using lifedashboard.Data;
using lifedashboard.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

           

                var checkPhone = await dB.MemberDetails.FirstOrDefaultAsync(x => x.Phone == collection.Phone);
                if(checkPhone!=null)
            {
                IEnumerable<string> name = from i in dB.MemberDetails where i.Phone == collection.Phone select i.Name;
                FeeCollection feeCollection = new FeeCollection()
                {
                    Id = Guid.NewGuid(),
                    MemberId = 1,
                    Name = name.First(),
                    Phone = collection.Phone,
                    FeeType = collection.FeeType,
                    FeeAmount = collection.FeeAmount,
                    DateOfPayment = collection.DateOfPayment,
                    Instructors = collection.Instructors,
                    CreateDate = DateTime.Now,
                    LastModifiedDate = DateTime.Now


                };
                try
                    {
                        await dB.FeeCollection.AddRangeAsync(feeCollection);
                        await dB.SaveChangesAsync();
                        ViewBag.Type = "Success";
                        ViewBag.ErrorMessage = "Data is saved";
                    }
                    catch (Exception ex)
                    {
                        ViewBag.Type = "Error";
                        ViewBag.ErrorMessage = ex;

                    }

                }
                else
                {
                    ViewBag.Type = "Warning";
                    ViewBag.ErrorMessage = "Member not found. Please contact the GYM administrator";
                   
                }
                                
               return View();

        }
    }
}
