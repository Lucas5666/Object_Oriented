using System;
namespace Factory
{
    //服务端数据访问工厂 生成 服务端 对数据做增删改查的Dao
    public class ServerDaoFactory : DaoFactory
    {


        public override IUserDao UserDao
        {
            get
            {
                return new UserServerDao();
            }
        }

        public override ICharacterDao CharacterDao
        {
            get
            {
                return new CharacterServerDao();
            }
        }
    }
}

