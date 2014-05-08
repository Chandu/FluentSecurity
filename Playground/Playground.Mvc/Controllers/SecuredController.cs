using System.Web.Mvc;

namespace Playground.Mvc.Controllers
{
	public class SecuredController : Controller
	{
		public ActionResult Index()
		{
			return Content("Am Secured controller");
		}
	}
}