namespace ConsoleApp3.Repositories.Interface;

public interface IRepository <T> where T: class
{
    int Insert(T obj);
    int Update(T obj);
    int Delete(int id);
    T GetById(int id);
    List<T> GetAll();
}