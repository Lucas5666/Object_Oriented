using System;
namespace Factory
{
	//客户端数据访问工厂
	public class ClientDaoFactory : DaoFactory
	{


		public override IUserDao UserDao
		{
			get
			{
				return new UserClientDao();
			}
		}

		public override ICharacterDao CharacterDao
		{
			get
			{
				return new CharacterClientDao();
			}
		}
	}
}

