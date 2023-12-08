using System;
namespace Factory
{
	public class UserServerDao : IUserDao
    {
		public void Add(User val)
		{
			Console.WriteLine("在服务端存储用户数据");
		}
	}
}

