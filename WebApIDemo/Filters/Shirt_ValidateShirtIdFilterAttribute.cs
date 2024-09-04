using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using WebApIDemo.Models.Repository;

namespace WebApIDemo.Filters
{
	public class Shirt_ValidateShirtIdFilterAttribute:ActionFilterAttribute
	{
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);

            var shirtId = context.ActionArguments["id"] as int?;
            if (shirtId.HasValue)
            {
                if (shirtId.Value <=0)
                {
                    context.ModelState.AddModelError("ShirtId", "ShirtId is invalid");
                    var problemDetails = new ValidationProblemDetails(context.ModelState)
                    {
                        Status = StatusCodes.Status400BadRequest
                    };
                    context.Result = new BadRequestObjectResult(problemDetails);
                }
                else if (!ShirtsRepository.ShirtExists(shirtId.Value))
                {
                    context.ModelState.AddModelError("ShirtId", "shirt doesn't exists");
                    var problemDetails = new ValidationProblemDetails(context.ModelState)
                    {
                        Status = StatusCodes.Status404NotFound
                    };
                    context.Result = new NotFoundObjectResult(problemDetails);
                }
            }
        }
    }
}

