using System;
namespace Inheritance
{
	public class Train : Transportation
    {
		public override void Transport()
		{
			Console.WriteLine("坐火车回家！");
		}
	}
}

