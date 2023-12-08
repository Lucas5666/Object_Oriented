namespace Factory;
class Program
{
    static void Main2(string[] args)
    {
        Console.WriteLine("Hello, World!");
        if(GameMain.Type == "Client")
        {
            UserClientDao userClientDao = new UserClientDao();
            userClientDao.Add(new User());
        }
        else
        {
            UserServerDao userServerDao = new UserServerDao();
            userServerDao.Add(new User());
        }
    }

    static void Main(string[] args)
    {
        DaoFactory factory = DaoFactory.Instance;
        IUserDao dao = factory.UserDao;
        dao.Add(new User());

        ICharacterDao dao2 = factory.CharacterDao;
        dao2.Add(new Character());

        Console.ReadKey();
    }

}

