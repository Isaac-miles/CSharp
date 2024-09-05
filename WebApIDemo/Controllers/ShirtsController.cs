using System;
using Microsoft.AspNetCore.Mvc;
using WebApIDemo.Filters;
using WebApIDemo.Filters.ExceptionFilters;
using WebApIDemo.Models;
using WebApIDemo.Models.Repository;

namespace WebApIDemo.Controllers
{
	[ApiController]
    [Route("api/[controller]")] //with this you dont need to add Route individually
	public class ShirtsController: ControllerBase
	{
      
        [HttpGet]
        //[Route("/shirts")]
        public IActionResult GetAllShirts()
        {
            return Ok(ShirtsRepository.GetAllShirts());
        }

        [HttpGet("{id}")]
        [Shirt_ValidateShirtIdFilter]

        public IActionResult GetShirt(int id)
        {
            //use the IActionResult return type when your method returns different type of data
            return Ok(ShirtsRepository.GetShirtById(id));
        }

        [HttpPost]
        [ValidateShirtCreatFilter]
        //[Route("/shirts")]
        public IActionResult CreateShirts( [FromBody] Shirt shirt)
        {
            ShirtsRepository.AddShirt(shirt);
            return CreatedAtAction(nameof(GetShirt), new {id = shirt.ShirtId }, shirt);
        }

        [HttpPut("{id}")]
        [Shirt_ValidateUpdateShirtFilter]
        [Shirt_ValidateShirtIdFilter]
        [Shirt_HandleUpdateException]
        //[Route("/shirts/{id}")]
        public IActionResult UpdatingShirt(int id, Shirt shirt)
        {

                ShirtsRepository.UpdateShirt(shirt);
            return NoContent();
        }

        [HttpDelete("{id}")]
        //[Route("/shirts/{id}")]
        public IActionResult DeletingShirt(int ID)
        {
            return Ok("Deleting the Shirts with ID:" + ID);

        }
    }
}

