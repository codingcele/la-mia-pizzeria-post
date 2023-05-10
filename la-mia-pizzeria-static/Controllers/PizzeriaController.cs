using la_mia_pizzeria_static.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace la_mia_pizzeria_static
{
    public class PizzeriaController : Controller
    {
        private readonly ILogger<PizzeriaController> _logger;

        public PizzeriaController(ILogger<PizzeriaController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            using (PizzeriaContext db = new PizzeriaContext())
            {
                List<Pizza> pizze = db.Pizze.ToList();

                return View(pizze);
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Details(int id)
        {
            using (PizzeriaContext context = new PizzeriaContext())
            {
                Pizza pizzaById = context.Pizze.Where(m => m.Id == id).FirstOrDefault();
                return View("Details", pizzaById);
            }
        }

        //public IActionResult Details(int id)
        //{
        //    using (PizzeriaContext context = new PizzeriaContext())
        //    {
        //        var pizzaId = context.Pizze.FirstOrDefault(p => p.Id == id);

        //        return View("Details", pizzaId);
        //    }
        //}

    }
}
