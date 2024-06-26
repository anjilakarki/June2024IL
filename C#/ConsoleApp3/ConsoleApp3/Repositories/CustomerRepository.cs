using ConsoleApp3.DataModel;
using ConsoleApp3.Repositories.Interface;

namespace ConsoleApp3.Repositories;

public class CustomerRepository: IRepository<Customer>
{
    private List<Customer> _customers = new List<Customer>();
    
    public int Insert(Customer obj)
    {
        if (GetById(obj.Id) == null)
        {
            _customers.Add(obj);
            return 1;
        }
        else
        {
            return 0;
        }
    }

    public int Update(Customer obj)
    {
        Customer c = GetById((obj.Id));
        if (c != null)
        {
            c.Id = obj.Id;
            c.Email = obj.Email;
            c.Name = obj.Name;
            return 1;
        }

        return 0;
    }

    public int Delete(int id)
    {
        Customer c = GetById(id);
        if (c != null)
        {
            _customers.Remove(c);
            return 1;
        }

        return 0;
    }

    public Customer GetById(int id)
    {
        for (int i = 0; i<_customers.Count; i++)
        {
            if (_customers[i].Id == id)
            {
                return _customers[i];
            }
        }
        return null;
    }

    public List<Customer> GetAll()
    {
        return _customers;
    }
}