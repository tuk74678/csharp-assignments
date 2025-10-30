// See https://aka.ms/new-console-template for more information


using System.Runtime.InteropServices.JavaScript;
using Assignment02;

int choice = -1;

while (choice != 0)
{
    Console.WriteLine("\t***WELCOME TO C# PRACTICE***");
    Console.WriteLine("1. Copying an Array\n" +
                      "2. To-Do List\n" +
                      "3. Calculate Prime Numbers\n" +
                      "4. Rotating Array\n" +
                      "5. Longest Sequence of Equal Elements\n" +
                      "6. Most Frequent Number\n" +
                      "7. Reverse String\n" +
                      "8. \n"
                      "0. Exit");
    Console.Write("Please enter a number choice from the menu: ");
    choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            Console.WriteLine("\n\t****COPYING AN ARRAY****");
            UnderstandingArrays.CopyingArray();
            Console.WriteLine(new string('*', 100)+ "\n");
            break;
        case 2:
            Console.WriteLine("\n\t****TO-DO LIST****");
            UnderstandingArrays.ToDoList();
            Console.WriteLine(new string('*', 100)+ "\n");
            break;
        case 3:
            Console.WriteLine("\n\t****CALCULATE PRIME NUMBER****");
            
            Console.Write("Please enter a start num: ");
            int startNum = int.Parse(Console.ReadLine());
            
            Console.Write("Please enter an end: ");
            int endNum = int.Parse(Console.ReadLine());
            int[] result = UnderstandingArrays.FindPrimesInRange(startNum, endNum);
            
            // combine an array elements into one string for output
            Console.WriteLine(string.Join(", ", result));
            Console.WriteLine(new string('*', 100)+ "\n");
            break;
        case 4:
            Console.WriteLine("\n\t****ROTATING ARRAYS****");
            
            Console.Write("Please generate an array number you want to rotate followed by a space: ");
            String arrayInput = Console.ReadLine();
            
            Console.Write("How many time do you want to rotate: ");
            int times = int.Parse(Console.ReadLine());
            int [] result1 = UnderstandingArrays.RotatingArrays(arrayInput, times);
            
            Console.WriteLine("Sum: " + string.Join(" ", result1));
            Console.WriteLine(new string('*', 100)+ "\n");
            break;
        case 5:
            Console.WriteLine("\n\t****LONGEST SEQUENCE OF EQUAL ELEMENTS****");
            
            String sample = "2 1 1 2 3 3 2 2 2 1" ;
            
            Console.WriteLine("Sample Sequence: " + sample);
            UnderstandingArrays.FindLongestSequence(sample);
            Console.WriteLine(new string('*', 100)+ "\n");
            break;
        case 6:
            Console.WriteLine("\n\t****MOST FREQUENT NUMBERS****");
            
            String sample1 = "4 1 1 4 2 3 4 4 1 2 4 9 3" ;
            String sample2 = "7 7 7 0 2 2 2 0 10 10 10";
            
            Console.WriteLine("Sample Sequence: " + sample1);
            UnderstandingArrays.FindMostFrequent(sample1);
            
            Console.WriteLine("Sample Sequence: " + sample2);
            UnderstandingArrays.FindMostFrequent(sample2);
            
            Console.WriteLine(new string('*', 100)+ "\n");
            break;
        case 7:
            Console.WriteLine("\n\t****REVERSE STRING****");
            
            String reverse = "sample";
            String reverse1 = "24tvcoi92";
            
            Console.Write("Sample string to be reversed: " + reverse + "\n");
            UnderstandingArrays.ReverseString(reverse);
            Console.WriteLine();
            Console.Write("Sample string to be reversed: " + reverse1 + "\n");
            UnderstandingArrays.ReverseString(reverse1);
            Console.WriteLine(new string('*', 100)+ "\n");
            break;
        case 8:
            break;
        case 0:
            Environment.Exit(0);
            break;
    }
}