namespace Assignment04;

public interface IRepository<T> where T : Entity        // reference type with id
{
    void Add(T item);
    void Remove(T item);
    void Save();
    IEnumerable<T> GetAll();
    T GetById(int id);
}