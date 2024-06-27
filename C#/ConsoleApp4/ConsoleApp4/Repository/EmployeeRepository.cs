using ConsoleApp4.DataModel;

namespace ConsoleApp4.Repository;

public class EmployeeRepository : IRepository<Employee>
{
    private List<Employee> employees = new List<Employee>
    {
        new Employee(){Id =1, FullName = "Scott", City="Sterling", Department = "IT", Salary = 5500},
        new Employee(){Id=2, FullName = "Peter", City="Sterling", Department = "HR", Salary = 4500},
        new Employee(){Id=3, FullName = "Laura", City="Chicago", Department = "IT", Salary = 3000},
        new Employee(){Id =4, FullName = "David", City = "Chicago", Department = "HR", Salary = 7000}
    };
    
    //get the employees by city

    // public List<Employee> GetByCity(string city)
    // {
    //     List<Employee> result = new List<Employee>();
    //     foreach (var employee in employees)
    //     {
    //         if (employee.City == city)
    //         {
    //             result.Add(employee);
    //         }
    //     }
    //
    //     return result;
    // }
    
    //get the employees by department 
    
    // public List<Employee> GetByDepartment(string department)
    // {
    //     List<Employee> result = new List<Employee>();
    //     foreach (var employee in employees)
    //     {
    //         if (employee.Department== department)
    //         {
    //             result.Add(employee);
    //         }
    //     }
    //
    //     return result;
    // }

    public List<Employee> Search(Func<Employee, bool> condition)
    {
        List<Employee> result = new List<Employee>();
        foreach (var employee in employees)
        {
            if (condition(employee))
            {
                result.Add(employee);
            }
        }

        return result;
    }
}