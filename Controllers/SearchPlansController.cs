using lifedashboard.Data;
using lifedashboard.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace lifedashboard.Controllers
{
    public class SearchPlansController : Controller
    {
        private readonly DBConfig db;
        public SearchPlansController(DBConfig Db)
        {
            this.db = Db;
        }


        [HttpGet]
        public IActionResult SearchPlans(string SearchString)
        {
           

            if (db.AddPlans == null)
            {
                return (Problem(@"No plans found. please use Add Plans tab for adding new routine / diet"));
            }

            var fetchPlan = from m in db.AddPlans
                             select m;

            if (!String.IsNullOrEmpty(SearchString))
            {
                SearchString = SearchString.Trim();
                //var fetchPlan = db.AddPlans.Where(p => p.Name!.Contains(SearchString)).ToList();
                //return View( fetchPlan);
                fetchPlan = db.AddPlans.Where(p => p.Name!.Contains(SearchString));
            }

            return View(fetchPlan.ToList());
            
        }

        [HttpPost]
        public ActionResult RedirectAction()
        {
            // Perform any necessary operations here

            // Redirect to another action or page
            return RedirectToAction("AddPlans", "AddPlans");
        }
    }
}
