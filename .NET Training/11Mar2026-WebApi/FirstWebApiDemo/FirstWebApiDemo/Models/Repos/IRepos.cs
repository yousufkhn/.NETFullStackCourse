namespace FirstWebApiDemo.Models.Repos
{
    public interface IRepos<T>
    {
        T Get(int id);
        ICollection<T> GetAll();
        bool Delete(int id);
        bool Add(T item);
        bool Update(int id,T item);


    }
}
