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
                    Console.WriteLine("⚠️ Warning: byte overflow about to occur!");
                }
                Console.WriteLine(i);
            }
        }
    }

    public static void GuessingNumber(int num)
    {
        int correctNumber = new Random().Next(3) + 1;
      
            if (num < 1 || num > 3)
            {
                Console.WriteLine("Out of range numbers!");
            }
            else if (num < correctNumber)
            {
                Console.WriteLine("Higher!");
            }
            else if (num > correctNumber)
            {
                Console.WriteLine("Lower!");
            }
            else
            {
                Console.WriteLine("Congrats! You got the right number!");
            }
        }
}