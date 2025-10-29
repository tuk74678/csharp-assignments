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
    public static void calCenturies(int centuries)
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
    
}