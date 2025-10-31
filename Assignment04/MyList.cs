namespace Assignment04;

public class MyList<T>
{
    private T[] array;
    private int count;
    
    // Constructor
    public MyList(int capacity)
    {
        array = new T[capacity];
        count = 0;
    }
    
    public void Add(T element)
    {
        if (count == array.Length)
        {
            Console.WriteLine("Array is full!");
        }
        array[count] = element;
        count++;
    }

    public T Remove(int index)
    {
        return ;
    }

    public bool Contains(T element)
    {
        return true;
    }

    public void Clear()
    {
        
    }

    public void InsertAt(T element, int index)
    {
        
    }

    public void DeleteAt(int index)
    {
        
    }

    public T Find(int index)
    {
        
    }
    
}