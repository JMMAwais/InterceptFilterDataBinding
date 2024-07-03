using Microsoft.AspNetCore.Mvc;
using System.Collections;

namespace InterceptFilterDataBinding.Controllers
{
   
    [Route("api/Request")]
    [ApiController]
    public class RequestController : Controller
	{

		[HttpGet]
		[Route("RequestData")]
		public IActionResult RequestData(HttpContext httpContext)
		{

			var request = httpContext.Request;

			var Accept = httpContext.Request.Headers["Accept"];
			var Method = request.Method;
			var scheme= request.Scheme;
			var host= request.Host;
			var requestPort = request.Host.Port;

            
            IHeaderDictionary headers = request.Headers; 
            headers["Accept"] = Accept;
            headers["Content-Type"] = scheme;
            headers.Add("Method",Method);
            headers.Add("Scheme",scheme);
            headers.Add("host", headers.Host);
           


            return Ok(headers);
			
		}

	}
}
