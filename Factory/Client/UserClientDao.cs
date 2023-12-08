using System;
namespace Factory
{
	public class UserClientDao :IUserDao
	{
		public void Add(User val)
		{
			Console.WriteLine("在客户端添加用户数据");
		}

		//public void Delete() { }
	}
}

