using System;
using Microsoft.AspNetCore.Mvc;
using WebApIDemo.Filters;
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

            //if(id <= 0)
            //{
            //    return BadRequest("Invalid Id");
            //}
            //var shirt = ShirtsRepository.GetShirtById(id);

            //if(shirt == null)
            //{
            //    return NotFound();
            //}

            //return Ok(shirt);
        }

        [HttpPost]
        [ValidateShirtCreatFilter]
        //[Route("/shirts")]
        public IActionResult CreateShirts( [FromBody] Shirt shirt)
        {
          
            return CreatedAtAction(nameof(GetShirt), new {id = shirt.ShirtId }, shirt);
        }

        [HttpPut("{id}")]
        //[Route("/shirts/{id}")]
        public IActionResult UpdatingShirt(int ID)
        {
            return Ok("Updating the Shirts with ID:" + ID);

        }

        [HttpDelete("{id}")]
        //[Route("/shirts/{id}")]
        public IActionResult DeletingShirt(int ID)
        {
            return Ok("Deleting the Shirts with ID:" + ID);

        }
    }
}

