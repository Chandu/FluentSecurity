using System.Web.Mvc;
using System.Web.Routing;
using FluentSecurity;
using FluentSecurity.Configuration;
using Playground.Mvc.Controllers;

namespace Playground.Mvc
{
	// Note: For instructions on enabling IIS6 or IIS7 classic mode,
	// visit http://go.microsoft.com/?LinkId=9394801
	public class MvcApplication : System.Web.HttpApplication
	{
		protected void Application_Start()
		{
			SecurityConfigurator.Configure<MvcConfiguration>(config =>
			{
				config.GetAuthenticationStatusFrom(() => false);
				config.For<SecuredController>().DenyAnonymousAccess();
				//config.For<HomeController>().Ignore();
			});

			AreaRegistration.RegisterAllAreas();
			FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
			RouteConfig.RegisterRoutes(RouteTable.Routes);

			
		}
	}
}