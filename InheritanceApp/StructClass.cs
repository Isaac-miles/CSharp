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
		public double DistanceTo( StructClass other)
		{
			double dx = other.x - x;
			double dy = other.y - y;
			return Math.Sqrt(dx * dx + dy * dy);
		}
	}
}

