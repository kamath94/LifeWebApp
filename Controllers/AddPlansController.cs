using lifedashboard.Data;
using lifedashboard.Models;
using Microsoft.AspNetCore.Mvc;

namespace lifedashboard.Controllers
{
    public class AddPlansController : Controller
    {
        private readonly DBConfig dB;
        public AddPlansController(DBConfig dB)
        {
            this.dB = dB;
        }

        // GET: AddPlansController
        public ActionResult AddPlans()
        {
            return View();
        }

        // GET: AddPlansController/Create
        [HttpPost]
        public async Task<ActionResult> AddPlans(AddPlans plans)

        {
            AddPlans newPlan = new AddPlans()
            {
                Id = Guid.NewGuid(),
                PhoneNumber = plans.PhoneNumber,
                Name = "Name", //plans.Name,
                DietPlan = plans.DietPlan,
                WorkoutPlan = plans.WorkoutPlan,
                CreateDate= DateTime.Now,
                LastModifiedDate= DateTime.Now
            };
            await dB.AddPlans.AddRangeAsync(newPlan);
            await dB.SaveChangesAsync();
           
            return View();
        }

        // POST: AddPlansController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AddPlansController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AddPlansController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AddPlansController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

       
    }
}
