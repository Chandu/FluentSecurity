using System.Web.Http;
using FluentSecurity;
using FluentSecurity.WebApi;
using FluentSecurity.WebApi.Configuration;
using Playground.WebApi.Controllers;

namespace Playground.WebApi
{
	// Note: For instructions on enabling IIS6 or IIS7 classic mode,
	// visit http://go.microsoft.com/?LinkId=9394801

	public class WebApiApplication : System.Web.HttpApplication
	{
		protected void Application_Start()
		{
			WebApiConfig.Register(GlobalConfiguration.Configuration);
			SecurityConfigurator.Configure<WebApiConfiguration>(config =>
			{
				config.GetAuthenticationStatusFrom(() => false);
				config.For<ValuesController>()
					.DenyAuthenticatedAccess();
				config.For<SecuredValuesController>()
					.DenyAnonymousAccess();
			});
			RegisterWebApiFilters(GlobalConfiguration.Configuration.Filters);

		}

		public static void RegisterWebApiFilters(System.Web.Http.Filters.HttpFilterCollection filters)
		{
			filters.Add(new HandleSecurityAttribute());
		}

	}
}