using System;
namespace Factory
{
	public class CharacterServerDao :ICharacterDao
	{

        public void Add(Character val)
        {
            Console.WriteLine("在服务端添加角色");
        }
    }
}

