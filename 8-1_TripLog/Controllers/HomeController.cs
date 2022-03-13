using _8_1_TripLog.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace _8_1_TripLog.Controllers
{
    public class HomeController : Controller
    {
        private TripLogContext context { get; set; }
        public HomeController(TripLogContext ctx) => context = ctx;

        public ViewResult Index()
        {
            var trips = context.Trips.OrderBy(t => t.StartDate).ToList();
            return View(trips);
        }
    }
}
