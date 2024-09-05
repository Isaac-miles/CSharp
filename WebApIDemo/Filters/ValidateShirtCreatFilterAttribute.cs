using System;
using Microsoft.AspNetCore.Mvc.Filters;

namespace WebApIDemo.Filters
{
	public class ValidateShirtCreatFilterAttribute: ActionFilterAttribute
	{
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);
        }
    }
}

