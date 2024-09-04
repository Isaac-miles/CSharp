using System;
namespace WebApIDemo.Models.Repository
{
	public static class ShirtsRepository
	{
        private static List<Shirt> shirts = new List<Shirt>()
        {
            new Shirt {ShirtId=1,Brand="Viton",Color="Blue",Gender="Men",Price=30,Size=10},
            new Shirt {ShirtId=2,Brand="Luios",Color="Green",Gender="Men",Price=20,Size=12},
            new Shirt {ShirtId=3,Brand="Xena",Color="Grey",Gender="Women",Price=15,Size=8},
            new Shirt {ShirtId=4,Brand="Okrika",Color="Pink",Gender="Women",Price=30,Size=9},

        };

        public static bool ShirtExists(int id)
        {
            return shirts.Any(x => x.ShirtId == id);
        }

    }
}

