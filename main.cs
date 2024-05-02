using System.IO;

Start


class Start
{
    static void Main(string[] args)
    {
        Console.WriteLine("Wie lautet dein name :");
        string username = Console.ReadLine() ?? "";
        Console.Write("Willkomen" + username);
    }

}