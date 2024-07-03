using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Diagnostics;
using System.Threading.Tasks;
using InterceptFilterDataBinding.Controllers;

namespace InterceptFilterDataBinding.Models
{
	// You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
	public class InterceptRequestMiddleware
	{
		private readonly RequestDelegate _next;

		public InterceptRequestMiddleware(RequestDelegate next)
		{
			_next = next;
		}

		public async Task Invoke(HttpContext httpContext)
		{
           
            RequestController requestControlller= new RequestController();
		    requestControlller.RequestData(httpContext);

            await _next(httpContext);
        }
	}

	
	public static class InterceptRequestMiddlewareExtensions
	{
		public static IApplicationBuilder UseInterceptRequestMiddleware(this IApplicationBuilder builder)
		{
			return builder.UseMiddleware<InterceptRequestMiddleware>();
		}
	}
}
