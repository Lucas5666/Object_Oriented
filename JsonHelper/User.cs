using System;
namespace JsonHelper
{
    public class User
    {
        public int ID { get; set; }

        public string LoginID { get; set; }

        public void Print()
        {
            Console.WriteLine("编号 : {0} , 账号 : {1}", ID, LoginID);
        }

    }
}

