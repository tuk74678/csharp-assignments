// See https://aka.ms/new-console-template for more information


using Assignment02;

int choice = -1;

while (choice != 0)
{
    Console.WriteLine("\t***WELCOME TO C# PRACTICE***");
    Console.WriteLine("1. Copying an Array\n" +
                      "2. To-Do List\n" +
                      "0. Exit");
    Console.Write("Please enter a number choice from the menu: ");
    choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            Console.WriteLine("\t****COPYING AN ARRAY****");
            UnderstandingArrays.CopyingArray();
            Console.WriteLine(new string('*', 100)+ "\n");
            break;
        case 2:
            Console.WriteLine("\t****TO-DO LIST****");
            UnderstandingArrays.ToDoList();
            Console.WriteLine(new string('*', 100)+ "\n");
            break;
        case 0:
            Environment.Exit(0);
            break;
    }
}