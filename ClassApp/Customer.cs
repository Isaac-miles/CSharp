﻿using System;
using System.Security.Cryptography;

namespace ClassApp
{
	public class Customer
	{
        private static int nextId = 0;
        private readonly int _id;

        public int Id { get => _id; }
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


        public void SetCustomerDetails(string name, string address, string contactNumber)
        {
            this.Address = address;
            this.Name = name;
            this.ContactNumber = contactNumber;
        }

        public void getCustomerDetails()
        {
            Console.WriteLine($"userId: {this._id} name: {this.Name} address {this.Address}  contact {this.Address}");
        }

        public static void MakeMe()
        {
            Console.WriteLine("I am static");
        }
    }
 

}

