// See https://aka.ms/new-console-template for more information

using System.Runtime.InteropServices;

Console.WriteLine("\t***********ASSIGNMENT 03***********\n");

int n;

Console.Write("Enter the length of the numbers: ");
n = int.Parse(Console.ReadLine());
Console.WriteLine();
int [] numbers = GenerateNumbers(n, 1, 100);

Console.Write("Array before: ");
PrintNumbers(numbers);
Console.WriteLine(new string('*', 100));
Console.Write("Array after:  ");
Reverse(numbers, n);
PrintNumbers(numbers);
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