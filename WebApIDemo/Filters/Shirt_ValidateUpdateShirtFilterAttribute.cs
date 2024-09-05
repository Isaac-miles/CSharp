using System;
using Microsoft.AspNetCore.Mvc.Filters;

namespace WebApIDemo.Filters
{
	public class Shirt_ValidateUpdateShirtFilterAttribute: ActionFilterAttribute
	{
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);

            var id = context.ActionArguments["id"] as int?;
        }
    }
}

