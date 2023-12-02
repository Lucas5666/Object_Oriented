namespace Inheritance;
class Program
{
    static void Main(string[] args)
    {
        Preson p1 = new Preson();
        p1.GoHome(new Airplane());

        Preson p2 = new Preson();
        p2.GoHome(new Train());


        Console.ReadKey();
    }
}

