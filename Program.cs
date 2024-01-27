using System.Globalization;
using System.Security.Cryptography;
using BasicConsoleApp.Classes;

internal class Program
{
    private static void Main(string[] args)
    {
        //This code below belongs to basics #1 chapter
        Console.Write("Enter circle radius: ");
        double radius = Convert.ToDouble(Console.ReadLine());

        CircleCalculate circleCalculate = new CircleCalculate(radius);
        circleCalculate.CircleArea();
        circleCalculate.CircleLength();


        //This code below belongs to basics #1 chapter
        Console.WriteLine("1. AnyCurrency => so'm\n2. so'm => AnyCurrency");
        int tanlov = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter amount of your money: ");
        int value = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter money rate: ");
        int moneyRate = Convert.ToInt32(Console.ReadLine());

        ConvertCurrency convertCurrency = new ConvertCurrency(value, moneyRate);

        if(tanlov == 1)
        {
            convertCurrency.ConvertToSom();
        }
        else if(tanlov == 2)
        {
            convertCurrency.ConvertToAnotherCurrency();
        }


        //This code below belongs to basics #1 chapter
        Console.Write("Enter your year: ");
        int year = Convert.ToInt32(Console.ReadLine());

        DateTime dateTime1 = new DateTime(year, 1, 1);
        DateTime dateTime2 = DateTime.Now;

        int days = (int)(dateTime2 - dateTime1).TotalDays;

        Console.WriteLine($"Since {dateTime1}, {days} days have passed!");


        //This code below belongs to besics #2 chapter
        Task1();
        Task2();
        Task3();


        //This code below belongs to basics #3 chapter
        Task1ForRepeatChapter();
        Task2ForRepeatChapter();
        Task3ForRepeatChapter();


        //This code below belongs to OOP chapter
        Console.Write("Enter book name: ");
        string bookName = Console.ReadLine();
        Console.Write("Enter author name: ");
        string authorName = Console.ReadLine();

        Book book = new Book(bookName, authorName);
        book.BookName = "Oila";
        book.AuthorName = "Fitrat";
        book.Price = 30000;
        book.Information();
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