using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Playground.WebApi.Controllers
{
	public class ValuesController : ApiController
	{
		// GET api/values
		public IEnumerable<string> Get()
		{
			return Enumerable.Range(1, 20).Select(a => "Value-" + a.ToString());
		}
	}
}