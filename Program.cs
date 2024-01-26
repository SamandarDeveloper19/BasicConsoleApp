using System.Globalization;
using System.Security.Cryptography;
using BasicConsoleApp.Classes;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter book name: ");
        string bookName = Console.ReadLine();
        Console.Write("Enter author name: ");
        string authorName = Console.ReadLine();

        Book book = new Book(bookName, authorName);
        book.BookName = "Oila";
        book.AuthorName = "Fitrat";
        book.Price = 30000;
        book.Information();
        
        // Task1();
        // Task2();
        // Task3();
        // Task1ForRepeatChapter();
        // Task2ForRepeatChapter();
        // Task3ForRepeatChapter();
    }

    static void Task1()
    {
        string str = "teLefOn";
        Console.Write("a = ");
        int a = Convert.ToInt32(Console.ReadLine());

        if (a > str.Length)
            Console.WriteLine(str.ToUpper());
        else
            Console.WriteLine(str.ToLower());
    }
    static void Task2()
    {
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
    }
    static void Task3()
    {
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
    static void Task1ForRepeatChapter()
    {
        int sum = 0;
        int i = 1;

        while(i < 1000)
        {
            sum += i;
            i += 2;
        }

        Console.WriteLine($"The sum of odd numbers till 1000 : {sum}");
    }
    static void Task2ForRepeatChapter()
    {
        int[] array = { 4, 9, 8, 3, 5, 6, 2 }; //for example
        int maxValue = array[0];
        int minValue = array[0];

        for(int j = 1; j < array.Length; j++)
        {
            minValue = array[j] < minValue ? array[j] : minValue;
            maxValue = array[j] > maxValue ? array[j] : maxValue;
        }
        
        Console.WriteLine($"{maxValue} * {minValue} = {minValue * maxValue}");
    }
    static void Task3ForRepeatChapter()
    {
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