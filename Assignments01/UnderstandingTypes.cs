using System.Security.Cryptography.X509Certificates;

namespace Assignments01;

public class UnderstandingType{
    
    public static void PrintHeader()
    {
        //Print a header before generating info
        Console.WriteLine("{0,-10} {1,10} {2,25} {3,25}", "Type", "Bytes", "Min Value", "Max Value");
        Console.WriteLine(new string('-', 75));
    }
    
    public static void PrintInfo()
    {
        DisplayInfo("sbyte", sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue);
        DisplayInfo("byte", sizeof(byte), byte.MinValue, byte.MaxValue);
        DisplayInfo("short", sizeof(short), short.MinValue, short.MaxValue);
        DisplayInfo("ushort", sizeof(ushort), ushort.MinValue, ushort.MaxValue);
        DisplayInfo("int", sizeof(int), int.MinValue, int.MaxValue);
        DisplayInfo("uint", sizeof(uint), uint.MinValue, uint.MaxValue);
        DisplayInfo("long", sizeof(long), long.MinValue, long.MaxValue);
        DisplayInfo("ulong", sizeof(ulong), ulong.MinValue, ulong.MaxValue);
        DisplayInfo("float", sizeof(float), float.MinValue, float.MaxValue);
        DisplayInfo("double", sizeof(double), double.MinValue, double.MaxValue);
        DisplayInfo("decimal", sizeof(decimal), decimal.MinValue, decimal.MaxValue);
    }
    // Create a DisplayInfo() to print all info and avoid redundancy
    private static void DisplayInfo(String type, int bytes, object min, object max)
    {
        Console.WriteLine("{0,-10} {1,10} {2,25} {3,25}", type, bytes, min, max);
    }
    // Create a calCenturies to do centuries calculation
    public static void CalCenturies(int centuries)
    {
        long years = centuries * 100;
        long days = years * 365;
        long hours = days * 24;
        long minutes = hours * 60;
        long seconds = minutes * 60;
        long milliseconds = seconds * 1000;
        long microseconds = milliseconds * 1000;
        long nanoseconds = microseconds * 1000;
        
    Console.WriteLine($"{centuries} centuries is = {years} years = {days} days = {hours} hours \n{minutes} minutes = " +
                      $"{seconds} seconds = {milliseconds} milliseconds \n{microseconds} microseconds = {nanoseconds} nanoseconds");    
    }
    // Fizzbuzz game with the count up to 100
    public static void Fizzbuzz()
    {
        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("fizzbuzz");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine("fizz");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("buzz");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }

    // Check code executiom
    public static void CodeExecution()
    {
        int max = 500;
        // Here I used checked to throw an OverflowException instead of going into an infinite loop
        checked
        {
            for (byte i = 0; i < max; i++)
            {
                // Print a message when an overflow is about to occur
                if (i == byte.MaxValue)
                {
                    Console.WriteLine(" Warning: byte overflow about to occur!");
                }
                Console.WriteLine(i);
            }
        }
    }
    // Guess number exercise
    public static int GuessingNumber(int num, int correctNumber)
    {
            if (num < 1 || num > 3)
            {
                Console.Write("Out of range numbers! Try again: ");
            }
            else if (num < correctNumber)
            {
                Console.Write("Higher, Try again: ");
            }
            else if (num > correctNumber)
            {
                Console.Write("Lower, Try again:");
            }
            else
            {
                Console.WriteLine("Congrats! You got the right number!");
            }
            return num;
    }
    
    // Print a pyramid
    public static void PrintPyramid()
    {
        int totalLines = 5;
        for (int i = 1; i <= totalLines; i++)
        {
            for (int space = totalLines - i; space > 0; space--)
            {
                Console.Write(" ");
            }
            for (int star = 1; star <= (2 * i) - 1; star++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
    
    // Check how many days old
    public static void CheckDaysOld(DateTime bd)
    {
          DateTime today = DateTime.Today;
          
          // Use TimeSpan to represent a time interval
          TimeSpan difference = today - bd;
          Console.WriteLine($"You are currently {difference.Days} days old!");
          
          // Calculate days until next anniversary
          int daysToNextAnniversary = 10000 - (difference.Days % 10000);
          DateTime nextAnniversary = today.AddDays(daysToNextAnniversary);
          Console.WriteLine($"You have {daysToNextAnniversary} days until your 10,000th day!");
    }
    // Greet user 
    public static void GreetUser()
    {
        DateTime time = DateTime.Now;
        //Console.WriteLine($"Now it is {time.Hour}:{time.Minute}");
        if (time.Hour >= 5 && time.Hour < 12)
        {
            Console.WriteLine("Good Morning");
        }
        else if (time.Hour >= 12 && time.Hour < 17)
        {
            Console.WriteLine("Good Afternoon");   
        }
        else if (time.Hour >= 17 && time.Hour < 21)
        {
            Console.WriteLine("Good Evening");
        }
        else
        {
            Console.WriteLine("Good Night");  
        }
    }
    // Counting number by 4 increments
    public static void FourIncrements()
    {
        int numIncrements = 4;

        for (int outer = 1; outer <= numIncrements; outer++)
        {
            for (int inner = 0; inner <= 24; inner += outer)
            {
                // print comma after each number until the last number
                Console.Write(inner);
                if (inner + outer <= 24)
                {
                    Console.Write(",");
                }
            }
            Console.WriteLine();
        }
        
    }
}