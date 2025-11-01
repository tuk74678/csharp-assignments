namespace Assignment04;

public class GenericRepository<T>: IRepository<Entity>
{
    public void Add(Entity item)
    {
        throw new NotImplementedException();
    }

    public void Remove(Entity item)
    {
        throw new NotImplementedException();
    }

    public void Save()
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Entity> GetAll()
    {
        throw new NotImplementedException();
    }

    public Entity GetById(int id)
    {
        throw new NotImplementedException();
    }
}