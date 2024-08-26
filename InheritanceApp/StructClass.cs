using System;
namespace InheritanceApp
{
	public struct StructClass
	{
		public int x { get; set; }
		public int y { get; set; }

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

