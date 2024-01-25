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

        //1-task for repeat chapter
        int sum = 0;
        int i = 1;

        while(i < 1000)
        {
            sum += i;
            i += 2;
        }

        Console.WriteLine($"The sum of odd numbers till 1000 : {sum}");

        //2-task for repeat chapter
        int[] array = { 4, 9, 8, 3, 5, 6, 2 }; //for example
        int maxValue = array[0];
        int minValue = array[0];

        for(int j = 1; j < array.Length; j++)
        {
            minValue = array[j] < minValue ? array[j] : minValue;
            maxValue = array[j] > maxValue ? array[j] : maxValue;
        }
        
        Console.WriteLine($"{maxValue} * {minValue} = {minValue * maxValue}");

        //3-task for repeat chapter
        Console.Write("Enter a number: ");
        int b = Convert.ToInt32(Console.ReadLine());

        int factorial = 1;
        for(int j = 1; j <= b; j++)
        {
            factorial = factorial * j;
        }

        Console.WriteLine($"{b}! = {factorial}");



    }
}