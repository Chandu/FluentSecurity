using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Playground.WebApi.Controllers
{
	public class SecuredValuesController : ApiController
	{
		public IEnumerable<string> Get()
		{
			return Enumerable.Range(1, 20).Select(a => "SecuredValue-" + a.ToString());
		}

		public IEnumerable<string> _UnderGet()
		{
			return Enumerable.Range(1, 20).Select(a => "UnsecuredValue-" + a.ToString());
		}
	}
}