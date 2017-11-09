using System.Web.Mvc;
using System.Web.SessionState;
using ControllerExtensibility.Models;

namespace ControllerExtensibility.Controllers
{
    [SessionState(SessionState.Disabled)]
    public class FastController : Controller
    {
        public ActionResult Index()
        {
            return View("Result", new Result { ControllerName = "Fast ", ActionName = "Index" });
        }
    }
}