using Castle.DynamicProxy;
using System;
using System.Diagnostics;
namespace InterceptFilterDataBinding.Models
{
	public class FilterInterception : IInterceptor
	{
	
        public FilterInterception()
        {
				
        }
        public void Intercept(IInvocation invocation)
		{
			var Action = invocation.Method.Name;
			var stopwatch = Stopwatch.StartNew();

		}
	}
}
