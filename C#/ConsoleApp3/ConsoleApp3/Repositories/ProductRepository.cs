using ConsoleApp3.DataModel;
using ConsoleApp3.Repositories.Interface;

namespace ConsoleApp3.Repositories;

public class ProductRepository : IRepository<Product>
{

    
    public int Insert(Product obj)
    {
        throw new NotImplementedException();
    }

    public int Update(Product obj)
    {
        throw new NotImplementedException();
    }

    public int Delete(int id)
    {
        throw new NotImplementedException();
    }

    public Product GetById(int id)
    {
        throw new NotImplementedException();
    }

    public List<Product> GetAll()
    {
        throw new NotImplementedException();
    }
}