using System.Globalization;
using System.Security.Cryptography;

internal class Program
{
    private static void Main(string[] args)
    {
        //1-task
        string str = "teLefOn";
        Console.Write("a = ");
        int a = Convert.ToInt32(Console.ReadLine());

        if (a > str.Length)
            Console.WriteLine(str.ToUpper());
        else
            Console.WriteLine(str.ToLower());

        //2-task
        Console.Write("x = ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.Write("y = ");
        int y = Convert.ToInt32(Console.ReadLine());

        if (x > y)
            Console.WriteLine("x is greater than");
        else if (x < y)
            Console.WriteLine("x is less than y");
        else if (x == y)
            Console.WriteLine("x is equal to y");
        else
            Console.WriteLine("x and y are not comparable each other");

        //3-task
        Console.Write("Enter a weekday: ");
        string weekday = Console.ReadLine();

        string result = weekday.ToLower() switch
        {
            "dushanba" => "Monday",
            "seshanba" => "Tuesday",
            "chorshanba" => "Wednesday",
            "payshanba" => "Thursday",
            "juma" => "Friday",
            "shanba" => "Saturday",
            "yakshanba" => "Sunday",
            _ => "Wrong enter!"
        };

        Console.WriteLine(result);
    }
}