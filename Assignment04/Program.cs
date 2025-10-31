// See https://aka.ms/new-console-template for more information

using Assignment04;

Console.WriteLine("\t***********ASSIGNMENT 04***********\n");
// 1. Custom Stack
Console.WriteLine("\t*****1.Custom Stack*****\n");

// Create an instance of MyStack class
MyStack<int> stack = new MyStack<int>(10);

stack.Push(1);
stack.Push(2);
stack.Push(3);

Console.WriteLine($"We popped the last added item: {stack.Pop()}");
Console.WriteLine($"There are {stack.Count()} elements in the stack.");
Console.WriteLine(new string('*', 50));

// 2. Generic List
Console.WriteLine("\t*****2. Generic List*****\n");

// Create an instance of MyStack class
MyList<int> myList = new MyList<int>();
