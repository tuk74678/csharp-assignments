namespace Assignment02;

public class UnderstandingArrays
{
    public static void CopyingArray()
    {
        int[] array1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int[] array2 = new int[array1.Length];
        
        Console.WriteLine("The first array is:");
        DisplayArray(array1);

        Console.WriteLine("\nThe second array is:");
        for (int i = 0; i < array1.Length; i++)
        {
            array2[i] =  array1[i]; 
        }
        DisplayArray(array2);
        Console.WriteLine();
    }

    // To do list 
    public static void ToDoList()
    {
        String[] array = new String[50];
        int count = 0;

        while (true)
        {
            Console.WriteLine("Enter command (+ item, - item, or -- to clear)):");
            Console.WriteLine("Enter 'exit' to quit");
            String input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
                continue;
            // adding item to the array
            if (input.StartsWith("+"))
            {
                // check if our limited sized array is full
                if (count >= array.Length)
                {
                    Console.WriteLine("Array is full!");
                    continue;
                }
                
                string item = input.Substring(2);
                array[count] = item;
                count++;
                Console.WriteLine($"Item Added: {item}");
            }
            else if (input.StartsWith("-"))
            {
                string item = input.Substring(2);
                bool removed = false;

                for (int i = 0; i < count; i++)
                {
                    // check if the input match anything in the array
                    if (array[i] == item)
                    {
                        // shift elements left
                        for (int j = i; j < count - 1; j++)
                        {
                            // duplicate the item then set the last item to null
                            array[j] = array[j + 1];
                        }
                        array[count - 1] = null;
                        count--;
                        removed = true;
                        Console.WriteLine($"Item Removed: {item}");
                        break;
                    }
                }
                if (!removed)
                    Console.WriteLine($"Item not found: {item}");
            }
            else if (input == "--")
            {
                Array.Clear(array, 0, array.Length); // clears the first 'count' elements
                count = 0;
                Console.WriteLine("Array cleared.");
            }
            // allow the user the exit into other program
            else if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid command.");
            }
            // print current array
            if (count > 0)
                Console.WriteLine("Current array: " + string.Join(", ", array, 0, count));
            else
                Console.WriteLine("Current array is empty.");
        }
    }

    // Create a method to only print array
    private static void DisplayArray(int[] array)
    {
        foreach (int i in array)
        {
            Console.Write($"{i} ");
        }
    }
    
    // Method to find prime with user provided range
    public static int[] FindPrimesInRange(int startNum, int endNum)
    {
        int max = (endNum - startNum) + 1;
        int[] array = new int[max];
        int count = 0; // count how many prime we found
        
        for (int i = startNum; i <= endNum; i++)
        {
            // number that are less than 2 are not prime so we skip
            if (i < 2) continue;
            bool isPrime = true; ;
            for (int j = 2; j * j <= i; j++)
            {
                if (i % j == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            // count the prime number so we can initialize the array size to store the result
            if (isPrime)
            {
                array[count] = i;
                count++;
            }
        }
        // return a trimmed array containing only the found primes
        int[] result = new int[count];
        for (int i = 0; i < count; i++)
            result[i] = array[i];
        return result;
    }
    
    // Method to do array rotation via user input
    public static int[] RotatingArrays(String input, int time)
    {
        int[] array = Array.ConvertAll(input.Split(), int.Parse);
        int n = array.Length;
        int [] sum = new int[n];
        
        for (int r = 1; r <= time; r++)
        {
            int[] rotated = new int[n];
            for (int i = 0; i < n; i++)
                rotated[(i + r) % n] = array[i];
    
            // we need to add the rotated array after many times it rotated
            for (int i = 0; i < n; i++)
                sum[i] += rotated[i];
        }
        return sum;
    }
    
    // Method to find the longest sequence
    public static void FindLongestSequence(String str)
    {
        int[] array = Array.ConvertAll(str.Split(), int.Parse);
        int maxLen = 1,         // length of the longest sequence
            currentLen = 1,     // track where the sequence start
            startIndex = 0;     // the actual sequence
        
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i - 1] == array[i])
            {
                currentLen++;
            }
            else
            {
                currentLen = 1;
            }
            // if we found a long sequence
            if (currentLen > maxLen)
            {
                // update the legnth of the longest sequence
                maxLen = currentLen;
                startIndex = i - maxLen + 1;
            }
            
        }
        Console.Write("The longest sequence is: ");
        // now we find the start of the first longest sequence then print the output seperated by a space
        for (int i = startIndex; i < startIndex + maxLen; i++){
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
    
    // Method to the find the most frequent number
    public static void FindMostFrequent(String str)
    {
        int [] array = Array.ConvertAll(str.Split(), int.Parse);
        int n = array.Length;
        int[] unique = new int[n]; // store unique numbers
        int[] count = new int[n];  // store counts
        int uniqueCount = 0;

        // count frequencies
        for (int i = 0; i < n; i++)
        {
            int num = array[i];
            int index = -1;

            // check if num is already in unique array
            for (int j = 0; j < uniqueCount; j++)
            {
                if (unique[j] == num)
                {
                    index = j;
                    break;
                }
            }

            if (index != -1)
            {
                // already exists → increment count
                count[index]++;
            }
            else
            {
                // new number → add to unique and set count=1
                unique[uniqueCount] = num;
                count[uniqueCount] = 1;
                uniqueCount++;
            }
        }

        // find most frequent number
        int maxCount = count[0];
        int mostFreq = unique[0];

        for (int i = 1; i < uniqueCount; i++)
        {
            if (count[i] > maxCount)
            {
                maxCount = count[i];
                mostFreq = unique[i];
            }
        }
        Console.WriteLine($"Most frequent: {mostFreq} (occurs {maxCount} times)");
    }
    
    // Method to reverse string
    public static void ReverseString()
    {
        
    }
    
}