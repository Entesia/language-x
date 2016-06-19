using System.Web.Mvc;

namespace LX.Controllers
{
    public class BaseController : Controller
    {
        public ActionResult Index()
        {
            return Redirect(Request.Url.Scheme + "://" + Request.Url.Authority + "/en-gb/home/index");
        }
    }
}