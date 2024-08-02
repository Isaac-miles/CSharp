using System;
namespace ClassApp
{

	public class Car
	{
        private string model;
		//string make;
		//bool isSport;

		public string Model { get=> model; set => model = value; }

		public string Make { get; set; }
		public bool isSport { get; set; }

        public Car(string model, string make, bool isSport)
		{
			this.model = model;
			this.Make = make;
			this.isSport = isSport;

		}

	}
}

