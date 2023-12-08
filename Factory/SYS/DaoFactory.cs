using System;
namespace Factory
{
	//数据访问工厂 生成客户端或服务端的数据访问对象  有生成的对象再去生成可以访问各自数据的Dao
	public abstract class DaoFactory
	{
		//public static IUserDao UsesDao
		//{
		//	get
		//	{
		//		if (GameMain.Type == "Client")
		//			return new UserClientDao();
		//		else
		//			return new UserServerDao();
		//	}
		//}

		public static DaoFactory Instance
		{
			get
			{
				if (GameMain.Type == "Client")
					return new ClientDaoFactory();
				else
					return new ServerDaoFactory();
			}
		}
		public abstract  IUserDao UserDao { get; }

		public abstract ICharacterDao CharacterDao { get; }
	}
}

