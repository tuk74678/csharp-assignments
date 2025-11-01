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

    // Use Count() to get the array size
    public int Count()
    {
        return count;
    }
    
    public void Add(T element)
    {
        if (count == array.Length)
        {
            throw new ArgumentOutOfRangeException("Index out of range");
        }
        array[count] = element;
        count++;
    }

    public T Remove(int index)
    {
        // Check if the provided index is valid otherwise print message
        if (index < 0 || index >= count)
        {
            throw new ArgumentOutOfRangeException("Index out of range");
        }

        T removed = array[index];
        for (int i = index; i < count - 1; i++)
        {
            array[i] = array[i + 1];
        }
        count--;
        return removed;
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

    // public T Find(int index)
    // {
    //     
    // }
    
}