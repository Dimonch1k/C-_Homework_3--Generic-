namespace Generic
{
    public interface IRepository<T>
    {
        string Add(T person); // Add the person to the List
        string Remove(int id); // Remove person by id
        T GetByID(int id); // Return person by id
    
        IEnumerable<T> GetAll(); // return whole List of people
    }
}
