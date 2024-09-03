using System;
using Microsoft.AspNetCore.Mvc;

namespace WebApIDemo.Controllers
{
	[ApiController]
	public class ShirtsController: ControllerBase
	{
        [HttpGet]
        [Route("/shirts")]
        public string GetAllShirts()
        {
            return "Get all Shirts";
        }

        [HttpGet]
        [Route("/shirts/{id}")]
        public string GetShirt(int ID)
        {
            return "Get the Shirts with ID:" + ID;
        }

        [HttpPost]
        [Route("/shirts")]
        public string CreateShirts()
        {
            return "Creating a shirt";
        }

        [HttpPut]
        [Route("/shirts/{id}")]
        public string UpdatingShirt(int ID)
        {
            return "Updating the Shirts with ID:" + ID;

        }

        [HttpDelete]
        [Route("/shirts/{id}")]
        public string DeletingShirt(int ID)
        {
            return "Deleting the Shirts with ID:" + ID;

        }
    }
}

