namespace JsonHelper;
class Program
{
    static void Main(string[] args)
    {
        User u1 = new User()
        {
            ID = 5,
            LoginID = "Hu"
        };

        string s2 = "{\"ID\":\"3\",\"LoginID\":\"HHH\"}";

        Console.WriteLine(JsonHelper.ObjectToJson(u1));

        User obj = JsonHelper.JsonToObject<User>(s2);

        Console.ReadKey();
    }
}

