using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using WebApIDemo.Models;
using WebApIDemo.Models.Repository;

namespace WebApIDemo.Filters
{
	public class ValidateShirtCreatFilterAttribute: ActionFilterAttribute
	{
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);

            var shirt = context.ActionArguments["shirt"] as Shirt;

            if(shirt == null)
            {
                context.ModelState.AddModelError("shirt", "shirt cannot be empty");
                var problemDetails = new ValidationProblemDetails(context.ModelState)
                {
                    Status = StatusCodes.Status400BadRequest

                };
                context.Result = new BadRequestObjectResult(problemDetails);
            }else
            {
                var existingShirt = ShirtsRepository.GetShirtByProps(shirt.Brand, shirt.Gender, shirt.Color, shirt.Size);
                if (existingShirt !=null)
                {
                    context.ModelState.AddModelError("shirt", "Shirt Already exists");
                    var problemDetails = new ValidationProblemDetails(context.ModelState)
                    {
                        Status = StatusCodes.Status400BadRequest
                    };
                    context.Result = new BadRequestObjectResult(problemDetails);
                }
                ShirtsRepository.AddShirt(shirt);
            }
        }
    }
}
