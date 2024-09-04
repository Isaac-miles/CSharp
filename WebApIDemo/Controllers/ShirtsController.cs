using System;
using Microsoft.AspNetCore.Mvc;

namespace WebApIDemo.Controllers
{
	[ApiController]
    [Route("api/[controller]")] //with this you dont need to add Route individually
	public class ShirtsController: ControllerBase
	{
        [HttpGet]
        //[Route("/shirts")]
        public string GetAllShirts()
        {
            return "Get all Shirts";
        }

        [HttpGet("{id}")]
        //[Route("/shirts/{id}/{color}")]
        //[FromQuery] string color / [FromRoute] string color  [FromHeader(Name ="color")] string color

        public string GetShirt(int id)
        {
            return $"Get the Shirts with ID: {id}";
        }

        [HttpPost]
        //[Route("/shirts")]
        public string CreateShirts()
        {
            return "Creating a shirt";
        }

        [HttpPut("{id}")]
        //[Route("/shirts/{id}")]
        public string UpdatingShirt(int ID)
        {
            return "Updating the Shirts with ID:" + ID;

        }

        [HttpDelete("{id}")]
        //[Route("/shirts/{id}")]
        public string DeletingShirt(int ID)
        {
            return "Deleting the Shirts with ID:" + ID;

        }
    }
}

