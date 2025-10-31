namespace Assignment04;

public class MyStack<T>
{
    private T[] stack;          // create an array of stack
    private int top = 0;        // index that points to the top of the element

    public MyStack()
    {
        
    }
    
    // create method to count the total size
    public int count()
    {
        return stack.Length;
    }
    
    // Push into the stack
    public void Push(T value)
    {
        
    }
    
    // Remove the top from stack
    public T Pop()
    {
        return stack[top];
    }
    
    
    
}