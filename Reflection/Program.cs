using System;
using System.Reflection;

namespace Reflection;
class Program
{
    static void Main(string[] args)
    {
        User user1 = new User();
        user1.ID = 1;
        user1.LoginID = "Cai";
        user1.Print();

        //获取类型 Type
        //Type type = Type.GetType("Reflection.User");
        //Type type = typeof(User);
        Type type = user1.GetType();

        //创建对象
        object obj = Activator.CreateInstance(type);

        //访问成员
        PropertyInfo p = type.GetProperty("ID");
        p.SetValue(obj, 2);
        PropertyInfo p2 = type.GetProperty("LoginID");
        p2.SetValue(obj, "Li");

        MethodInfo m = type.GetMethod("Print");
        m.Invoke(obj,null);

        Console.ReadKey();
    }
}

