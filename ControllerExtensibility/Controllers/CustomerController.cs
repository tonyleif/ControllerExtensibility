using System.Web.Mvc;
using ControllerExtensibility.Models;

namespace ControllerExtensibility.Controllers
{
    public class CustomerController : Controller
    {
        public ViewResult Index()
        {
            return View("Result", new Result { ControllerName = "Customer", Actionname = "List" });
        }

        [ActionName("Enumerate")]
        public ViewResult List()
        {
            return View("Result", new Result { controller = "Customer", action = "Lists" });
        }

        [NonAction]
        public ActionResult MyAction()
        {
            return View();
        }
    }
}