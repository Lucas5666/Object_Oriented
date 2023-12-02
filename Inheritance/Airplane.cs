using System;
namespace Inheritance
{
	public class Airplane : Transportation
	{
        public override void Transport()
        {
            Console.WriteLine("坐飞机回家！");
        }
    }
}

