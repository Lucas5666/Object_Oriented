using System;
namespace Factory
{
	public class CharacterClientDao : ICharacterDao
	{

        public void Add(Character val)
        {
            Console.WriteLine("在客户端添加角色");
        }
    }
}

