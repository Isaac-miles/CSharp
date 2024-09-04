using System;
using Microsoft.AspNetCore.Mvc;
using WebApIDemo.Models;

namespace WebApIDemo.Controllers
{
	[ApiController]
    [Route("api/[controller]")] //with this you dont need to add Route individually
	public class ShirtsController: ControllerBase
	{
        private List<Shirt> shirts = new List<Shirt>()
        {
            new Shirt {ShirtId=1,Brand="Viton",Color="Blue",Gender="Men",Price=30,Size=10},
            new Shirt {ShirtId=2,Brand="Luios",Color="Green",Gender="Men",Price=20,Size=12},
            new Shirt {ShirtId=3,Brand="Xena",Color="Grey",Gender="Women",Price=15,Size=8},
            new Shirt {ShirtId=4,Brand="Okrika",Color="Pink",Gender="Women",Price=30,Size=9},

        };


        [HttpGet]
        //[Route("/shirts")]
        public string GetAllShirts()
        {
            return "Get all Shirts";
        }

        [HttpGet("{id}")]
        //[Route("/shirts/{id}/{color}")]
        //[FromQuery] string color / [FromRoute] string color  [FromHeader(Name ="color")] string color

        public IActionResult GetShirt(int id)
        {
            //use the IActionResult return type when your method returns different type of data
            Shirt shirt = shirts.First(x => x.ShirtId == id);
            if(shirt == null)
            {
                return NotFound();
            }

            return Ok(shirt);
        }

        [HttpPost]
        //[Route("/shirts")]
        public Shirt CreateShirts( [FromBody] Shirt shirt)
        {
            return shirt;
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

