using System.Web.Mvc;

namespace Appplication.Api.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return Redirect("swagger/ui/index");
        }
    }
}
