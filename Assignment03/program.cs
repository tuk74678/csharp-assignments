// See https://aka.ms/new-console-template for more information

using System.Runtime.InteropServices;
using Assignment03;

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

// Create department
var dept = new Department("Computer Science", 100000, new DateTime(2025, 1, 1),
    new DateTime(2026, 1, 1));
// Create instructor
var instructor = new Instructor("Dr. Logan Mcdonnell", new DateTime(1980, 5, 10), 80000m,
    new DateTime(2010, 6, 1));
dept.Head = instructor;

// Create course
var course1 = new Course("OOP in C#");
var course2 = new Course("Data Structures");
dept.AddCourse(course1);
dept.AddCourse(course2);

// Create student
var student = new Student("Harry Potter", new DateTime(2003, 8, 15));
student.EnrollCourse(course1, 'A');
student.EnrollCourse(course2, 'B');

// Display Information
dept.DisplayDepartmentInfo();
instructor.DisplayInfo();
student.DisplayInfo();

// Color and Ball Classes
Console.WriteLine("\n\t*****Ball and Color OOP*****");
// Create an instance of a class 
var redColor = new Color(255, 0, 0);
var ball = new Ball(5, redColor);

ball.Throw();
ball.Throw();
ball.Pop();
ball.Throw(); // won’t count
Console.WriteLine($"Ball Color: {ball.Color}, Throw Count: {ball.GetThrowCount()}, Size: {ball.Size}");
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