using System.Web.Mvc;
using ControllerExtensibility.Infrastructure;
using ControllerExtensibility.Models;

namespace ControllerExtensibility.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View("Result", new { ControllerName = "Home", ActitonName = "Index" });
        }

        [Local]
        [ActionName("Index")]
        public ActionResult LocalIndex()
        {
            return View("Result", new { ControllerName = "Home", ActionName = "LocalIndex" });
        }

        protected override void HandleUnknownAction(string actionName)
        {
            Response.Write("You requested the {0} action", actionName);
        }
    }
}