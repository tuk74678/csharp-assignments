// See https://aka.ms/new-console-template for more information

// Playing with console app

using Assignments01;

int choice = -1;

// Create a main menu with Switch Case statement
while (choice != 0)
{
    Console.WriteLine("\t***WELCOME TO C# PRACTICE***");
    Console.WriteLine("1. Hacker Name Generator\n" +
                      "2. Practice Number Sizes and Range\n" +
                      "3. Convert Centuries into Days,Years, Hours...\n" +
                      "4. Fizzbuzz\n" +
                      "5. Code Execution\n" +
                      "6. Guessing Number\n" + 
                      "0. Exit");
    Console.WriteLine("Please enter a number choice from the menu:");
    choice = int.Parse(Console.ReadLine());
    
    switch (choice)
    {
        case 1: //Playing with console app
            Console.WriteLine("\t****HACKER NAME GENERATOR!****");
            Console.WriteLine("Please enter your favorite color: ");
            String color = Console.ReadLine();
            Console.WriteLine("Please enter your astrology sign: ");
            String sign = Console.ReadLine();
            Console.WriteLine("Please enter your street address number: ");
            String adNum = Console.ReadLine();
            Console.WriteLine($"Woohoo! Your hacker name is {color}{sign}{adNum}");
            Console.WriteLine(new string('*', 100)+ "\n");
        break;
        case 2: // Practice number sizes and range
            
            // Call all methods from UnderstandingType class
            UnderstandingType.PrintHeader();
            // Call PrintInfo() to print all the data
            UnderstandingType.PrintInfo();
            Console.WriteLine(new string('*', 100)+ "\n"); 
            break;
        case 3: // Centuries Converter
            Console.WriteLine("Please enter a number of centuries:");
            int centuries = int.Parse(Console.ReadLine());
            // Call calCenturies() to do calculation from UnderstandingType class
            UnderstandingType.CalCenturies(centuries);
            Console.WriteLine(new string('*', 100)+ "\n");
            break;
        case 4:
            UnderstandingType.Fizzbuzz();
            Console.WriteLine(new string('*', 100)+ "\n");
            break;
        case 5:
            UnderstandingType.CodeExecution();
            Console.WriteLine(new string('*', 100)+ "\n");
            break;
        case 6:
            Console.WriteLine("Please pick a number and I'll tell higher or lower: ");
            int guessedNumber = int.Parse(Console.ReadLine());
            UnderstandingType.GuessingNumber(guessedNumber);
            Console.WriteLine(new string('*', 100)+ "\n");
            break;
        case 0:
            Environment.Exit(0);
            break;
    }
}




