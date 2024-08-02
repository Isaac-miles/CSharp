using System;
namespace ClassApp
{
	public class Customer
	{
        public string Name { get; set; }
		public string Address { get; set; }
		public string ContactNumber { get; set; }

        public Customer()
        {
            this.Name = "New record";
			this.Address = "nomial@gmail.com";
			this.ContactNumber = "45678";
        }

        public Customer(string name, string address, string contactNumber)
		{
			this.Address = address;
			this.Name = name;
			this.ContactNumber = contactNumber;
		}

	}
}

