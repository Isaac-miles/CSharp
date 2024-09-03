using System;
using Microsoft.AspNetCore.Mvc;

namespace WebApIDemo.Controllers
{
	[ApiController]
	public class ShirtsController: ControllerBase
	{
        public string GetAllShirts()
        {
            return "Get all Shirts";
        }

        public string GetShirt(int ID)
        {
            return "Get the Shirts with ID:" + ID;
        }

        public string CreateShirts()
        {
            return "Creating a shirt";
        }

        public string UpdatingShirt(int ID)
        {
            return "Updating the Shirts with ID:" + ID;

        }

        public string DeletingShirt(int ID)
        {
            return "Deleting the Shirts with ID:" + ID;

        }
    }
}

