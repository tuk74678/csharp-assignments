// See https://aka.ms/new-console-template for more information

using System.Runtime.InteropServices;

Console.WriteLine("\t***********ASSIGNMENT 03***********\n");

// Array reverse
Console.WriteLine("\t*****Reverse Array*****");
int n;
Console.Write("Enter the length of the numbers: ");
n = int.Parse(Console.ReadLine());
Console.WriteLine();
int [] numbers = GenerateNumbers(n, 1, 100);

Console.Write("Array before: ");
PrintNumbers(numbers);
Console.WriteLine(new string('*', 50));
Console.Write("Array after:  ");
Reverse(numbers, n);
PrintNumbers(numbers);
Console.WriteLine(new string('*', 50));

// Fibonacci Sequence
Console.WriteLine("\n\t*****Fibonacci Sequence*****");
Console.WriteLine("\nFirst 10 Fibonacci numbers:");
for (int i = 1; i <= 10; i++)
{
    Console.Write(Fibonacci(i) + " ");
}
Console.WriteLine();

// OOP
Console.WriteLine("\n\t*****Object-Oriented Programming*****");


// Create student
var student = new Student();

// Create department
var dept = new Department();

// Create course
var course = new Course();

// Create instructor
var instructor = new Instructor();


// Create a method to generate number based on user input
static int[] GenerateNumbers(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();      // use Random class to help with array generating

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);      // max possible is 100, 101 is exclusive 
    }
    return array;
}

// Create a method to print all elements in array using foreach
static void PrintNumbers(int[] numbers)
{
    foreach (int number in numbers)
    {
        Console.Write(number + " ");
    }
    Console.WriteLine();
}

// Create a method to reverse the array
static void Reverse(int[] numbers, int length)
{
    for (int i = 0; i < length / 2; i++)
    {
        int temp = numbers[i];
        numbers[i] = numbers[length - i - 1];
        numbers[length - i - 1] = temp;
    }
}

// Create a method to return Fibonacci number
static int Fibonacci(int n)
{
    if (n == 1 || n == 2)
    {
        return 1;
    }
    else
    {
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}