namespace Assignment04;

public class MyStack<T>
{
    private T[] stack;      // create an array of stack
    private int top;        // index that points to the top of the element

    // Create a constructor
    public MyStack(int capacity)
    {
        stack = new T[capacity];
        top = -1;   // -1 means empty stack
    }
    
    // create method to count the total size
    public int Count()
    {
        return top + 1;
    }
    
    // Push into the stack
    public void Push(T value)
    {
        if (top == stack.Length - 1)
        {
            Console.WriteLine("Stack is full!");
        }
        top++;
        stack[top] =  value;
    }
    
    // Remove the top from stack
    public T Pop()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack is empty!");
        }
        T popped = stack[top];
        --top;
        return popped;
    }
    
    
    
}