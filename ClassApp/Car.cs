using System;
namespace ClassApp
{

	public class Car
	{
        private string model;
		string make;
		int year;

		public string Model { get=> model; set => model = value; }

        public string Make {

			get => make;

			set{
				if (string.IsNullOrEmpty(value))
				{
					make = "default";
				}
				else
				{
					make = value;
				}
			}

		}

        public Car(string model, string make, int year)
		{
			this.model = model;
			this.Make = make;
			this.year = year;

		}

	}
}

