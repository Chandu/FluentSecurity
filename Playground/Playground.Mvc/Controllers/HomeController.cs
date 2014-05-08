using System.Web.Mvc;

namespace Playground.Mvc.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return Content("Am home controller");
		}
	}
}