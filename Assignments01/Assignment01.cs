// See https://aka.ms/new-console-template for more information

// Playing with console app

using Assignments01;

Console.WriteLine("****HACKER NAME GENERATOR!****");
Console.WriteLine("Please enter your favorite color: ");
String color = Console.ReadLine();
Console.WriteLine("Please enter your astrology sign: ");
String sign = Console.ReadLine();
Console.WriteLine("Please enter your street address number: ");
String adNum = Console.ReadLine();
Console.WriteLine($"Woohoo! Your hacker name is {color}{sign}{adNum}");
Console.WriteLine(new string('*', 100)+ "\n");

// Practice number sizes and range
// Call all methods from UnderstandingType class
UnderstandingType.PrintHeader();
// Call PrintInfo() to print all the data
UnderstandingType.PrintInfo();
Console.WriteLine(new string('*', 100)+ "\n");