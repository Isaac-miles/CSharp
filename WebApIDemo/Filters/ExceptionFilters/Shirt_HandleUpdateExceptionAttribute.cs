using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using WebApIDemo.Models.Repository;

namespace WebApIDemo.Filters.ExceptionFilters
{
	public class Shirt_HandleUpdateExceptionAttribute:ExceptionFilterAttribute
	{
        public override void OnException(ExceptionContext context)
        {
            base.OnException(context);

            var strShirtId = context.RouteData.Values["id"] as string;
            if(int.TryParse(strShirtId, out int shirtId))
            {
                if (!ShirtsRepository.ShirtExists(shirtId))
                {
                    context.ModelState.AddModelError("ShirtId", "shirt doesn't exist");
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

