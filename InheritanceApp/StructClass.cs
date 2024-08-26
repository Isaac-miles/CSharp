using System;
namespace InheritanceApp
{
	public struct StructClass
	{
		////properties
		//public int x { get; set; }
		//public int y { get; set; }

		//fields
		public int x;
		public int y;

        public StructClass(int x, int y)
		{
			this.x = x;
			this.y = y;

		}
		public void Display()
		{
			Console.WriteLine($"{x}  and  {y}");
		}
	}
}

