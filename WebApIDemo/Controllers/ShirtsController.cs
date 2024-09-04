using System;
using Microsoft.AspNetCore.Mvc;
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
            return Ok("Get all Shirts");
        }

        [HttpGet("{id}")]
        //[Route("/shirts/{id}/{color}")]
        //[FromQuery] string color / [FromRoute] string color  [FromHeader(Name ="color")] string color

        public IActionResult GetShirt(int id)
        {
            //use the IActionResult return type when your method returns different type of data

            if(id <= 0)
            {
                return BadRequest("Invalid Id");
            }
            var shirt = ShirtsRepository.GetShirtById(id);

            if(shirt == null)
            {
                return NotFound();
            }

            return Ok(shirt);
        }

        [HttpPost]
        //[Route("/shirts")]
        public IActionResult CreateShirts( [FromBody] Shirt shirt)
        {
            return Ok(shirt);
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

