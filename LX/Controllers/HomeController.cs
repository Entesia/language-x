using System.Web.Mvc;
using System.Linq;
using LX.Enums;
using LX.Infrastructure.Routing;
using LX.Models;

namespace LX.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string error)
        {
            using (var contex = new LanguagesDbContext())
            {
                var model = new CriteriaVm
                {
                    Make = contex.Makes.Include("MakeContent").ToList(),
                    Model = contex.Models.ToList(),
                    Error = error != null ? Translations.Translate("MessageForError", ContentType.Validation) : ""
                };
                return View(model);
            }
        }

        public ActionResult PageNotFound()
        {
            return View();
        }
    }
}