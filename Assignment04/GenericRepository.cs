namespace Assignment04;

public class GenericRepository<T>: IRepository<T> where T : Entity
{
    private readonly List<T> items = new List<T>();        // use readonly to ensure variable reference cannot be reassigned 
    
    public void Add(T item)
    {
        if (item == null)
        {
            throw new ArgumentNullException(nameof(item));
        }
        items.Add(item);
        Console.WriteLine($"Added item with Id={item.Id}");
    }

    public void Remove(T item)
    {
        throw new NotImplementedException();
    }

    public void Save()
    {
        throw new NotImplementedException();
    }

    public IEnumerable<T> GetAll()
    {
        throw new NotImplementedException();
    }

    public T GetById(int id)
    {
        throw new NotImplementedException();
    }
}