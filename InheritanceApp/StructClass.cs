using System;
namespace InheritanceApp
{
	public struct StructClass
	{
		//properties
		public double x { get; }
		public double y { get;}

		//fields
		//public int x;
		//public int y;

		public StructClass(int x, int y)
		{
			this.x = x;
			this.y = y;

		}
		public void Distance()
		{
			Console.WriteLine($"{x}  and  {y}");
		}
	}
}

