using System;
using System.Security.Cryptography;

namespace ClassApp
{
	public class Customer
	{
        private static int nextId = 0;
        private readonly int _id;

        public string Name { get; set; }
		public string Address { get; set; }
		public string ContactNumber { get; set; }

        public Customer()
        {
            _id = nextId++;
            this.Name = "New record";
			this.Address = "nomial@gmail.com";
			this.ContactNumber = "45678";
        }

        public Customer(string name, string address, string contactNumber)
		{
            _id = nextId++;
            this.Address = address;
			this.Name = name;
			this.ContactNumber = contactNumber;
		}


        public void SetDetails(string name, string address, string contactNumber)
        {
            this.Address = address;
            this.Name = name;
            this.ContactNumber = contactNumber;
        }

        public static void MakeMe()
        {
            Console.WriteLine("I am static");
        }
    }
 

}

