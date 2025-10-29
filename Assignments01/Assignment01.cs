// See https://aka.ms/new-console-template for more information

// Playing with console app

using System.Runtime.InteropServices.Marshalling;
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
                      "7. Print-a-Pyramid\n" +
                      "8. Check How Many Days Old\n" +
                      "9. Appropriate Greeting\n" +
                      "10 Counting By 4 Increments\n" +
                      "0. Exit");
    Console.Write("Please enter a number choice from the menu: ");
    choice = int.Parse(Console.ReadLine());
    
    switch (choice)
    {
        case 1: //Playing with console app
            Console.WriteLine("\t****HACKER NAME GENERATOR!****");
            Console.Write("Please enter your favorite color: ");
            String color = Console.ReadLine();
            Console.Write("Please enter your astrology sign: ");
            String sign = Console.ReadLine();
            Console.Write("Please enter your street address number: ");
            String adNum = Console.ReadLine();
            Console.WriteLine($"Woohoo! Your hacker name is {color}{sign}{adNum}");
            Console.WriteLine(new string('*', 100)+ "\n");
        break;
        case 2: // Practice number sizes and range
            Console.WriteLine("\t****NUMBER SIZES AND RANGE!****");
            // Call all methods from UnderstandingType class
            UnderstandingType.PrintHeader();
            // Call PrintInfo() to print all the data
            UnderstandingType.PrintInfo();
            Console.WriteLine(new string('*', 100)+ "\n"); 
            break;
        case 3: // Centuries Converter
            Console.WriteLine("\t****CENTURIES CONVERTER****");
            Console.Write("Please enter a number of centuries:");
            int centuries = int.Parse(Console.ReadLine());
            // Call calCenturies() to do calculation from UnderstandingType class
            UnderstandingType.CalCenturies(centuries);
            Console.WriteLine(new string('*', 100)+ "\n");
            break;
        case 4:
            Console.WriteLine("\t****FIZZBUZZ****");
            UnderstandingType.Fizzbuzz();
            Console.WriteLine(new string('*', 100)+ "\n");
            break;
        case 5:
            Console.WriteLine("\t****CODE EXECUTION****");
            UnderstandingType.CodeExecution();
            Console.WriteLine(new string('*', 100)+ "\n");
            break;
        case 6:
            Console.WriteLine("\t****GUESSING NUMBER****");
            Console.Write("Please pick a number and I'll tell higher or lower: ");

            int guessedNumber = 0;
            int correctNumber = new Random().Next(3) + 1;
            while (guessedNumber != correctNumber)
            {
                guessedNumber = int.Parse(Console.ReadLine());
                UnderstandingType.GuessingNumber(guessedNumber, correctNumber); 
            }
            Console.WriteLine(new string('*', 100)+ "\n");
            break;
        case 7: 
            Console.WriteLine("\t****PRINT A PYRAMID");
            UnderstandingType.PrintPyramid();
            break;
        case 8:
            Console.WriteLine("\t****BIRTHDAY CHECKER****");
            Console.Write("Please enter your birthday in MM/DD/YYYY: ");
            DateTime birthday;
            bool isValid = false;
           
            while (!isValid)
            {
                string bd = Console.ReadLine(); // read input each loop
                isValid = DateTime.TryParse(bd, out birthday);
                
                if (isValid)
                {
                    UnderstandingType.CheckDaysOld(birthday);
                }
                else
                {
                    Console.Write("Your birthday is not in the correct format! Please try again: ");
                }
            }
            Console.WriteLine(new string('*', 100)+ "\n");
            break;
        case 9:
            Console.WriteLine("\t****GREET USERS****");
            UnderstandingType.GreetUser();
            Console.WriteLine(new string('*', 100)+ "\n");
            break;
        case 10:
            Console.WriteLine("\t****4 INCREMENTS OF 24****");
            UnderstandingType.FourIncrements();
            Console.WriteLine(new string('*', 100)+ "\n");
            break;
        case 0:
            Environment.Exit(0);
            break;
    }
}




