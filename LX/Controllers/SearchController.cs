using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using LX.Enums;
using LX.Infrastructure.Routing;
using LX.Models;

namespace LX.Controllers
{
    public class SearchController : Controller
    {
        public ActionResult Index(SearchVm car)
        {
            if (car.Error != null)
            {
                int? make = car.Make?.Id;
                int? model = car.Model?.Id;
                using (var db = new LanguagesDbContext())
                {
                    car.Motor = car.Motor ?? new List<MotorType>();
                    bool allCars = (car.Make == null || car.Make.Id == 0) && (car.Model == null || car.Model.Id == 0);
                    var result = db.Cars.Where(r => (allCars || (r.MakeId == make && (model == 0 || r.ModelId == model)))
                                                    && (car.ForRent == null || car.ForRent == r.ForRent)).ToList()
                                                    .Where(r => !car.Motor.Any() || car.Motor.Contains(r.Motor)).ToList().Select(r => new CarVm(r)).ToList();
                    return View(result);
                }
            }
            return RedirectToAction("Index", "Home", new { error = Translations.Translate("MessageForError", ContentType.Validation) });
        }
    }
}