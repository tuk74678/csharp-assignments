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
        for (int i = 0; i < count - 1; i++)
        {
            if (array[i].Equals(element))
            {
                return true;
            }
           
        }
        return false;
    }

    public void Clear()
    {
        // Using Array.Clear to logical remove all elements in the array
        Array.Clear(array, 0, count);
        count = 0;
    }

    public void InsertAt(T element, int index)
    {
        if (index < 0 || index > count)
        {
            throw new ArgumentOutOfRangeException("Index out of range");
        }

        for (int i = count; i > index; i--)
        {
            // move an element to the right
            array[i] = array[i - 1];
        }        
        array[index] = element;
        count++;
    }

    public void DeleteAt(int index)
    {
        Remove(index);
    }

    public T Find(int index)
    {
        if (index < 0 || index >= count) throw new ArgumentOutOfRangeException();
        return array[index];
    }
    
}