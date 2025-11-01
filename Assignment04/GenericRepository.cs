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
        if (item == null)
            throw new ArgumentNullException(nameof(item));
        items.Remove(item);
        Console.WriteLine($"Removed item with Id={item.Id}");
    }

    public void Save()
    {
        // save logic
        Console.WriteLine("Changes saved.");
    }

    public IEnumerable<T> GetAll()
    {
        return items.ToList(); // return a copy to prevent external modification
    }

    public T GetById(int id)
    {
        return items.FirstOrDefault(x => x.Id == id);
    }
}