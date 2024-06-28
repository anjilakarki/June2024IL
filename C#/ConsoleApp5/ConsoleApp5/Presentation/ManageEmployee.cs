using ConsoleApp5.DataModel;
using ConsoleApp5.Repositories;

namespace ConsoleApp5.Presentation;

public class ManageEmployee
{
    private EmployeeRepository _employeeRepository = new EmployeeRepository();

    // private Employee demo(Employee e)
    // {
    //     return e;
    // }
    
    private void SelectDemo()
    {
        //Select
        
        //Select * from employee
        
        //Query Syntax : sql like syntax
        // var result = from employee in _employeeRepository.GetEmployees()
        //     select employee;
        
        //Method Syntax: bunch of extension methods
        // var result = _employeeRepository.GetEmployees().Select(employee=>employee);
        
        // foreach (var employee in result)
        // {
        //     Console.WriteLine(employee.Id + "\t" + employee.FullName + "\t" +employee.Department);
        // }
        
        //select certain properties: FullName
        
        //Query syntax
        // var result = from employee in _employeeRepository.GetEmployees()
        //     select employee.FullName;

        
        //Method syntax
        // var result = _employeeRepository.GetEmployees().Select(employee=>employee.FullName);
        //
        // foreach (var FullName in result)
        // {
        //     Console.WriteLine(FullName);
        // }
        
        //Selecting multiple properties
        //Query Syntax
        // var result = from employee in _employeeRepository.GetEmployees()
        //     select new
        //     {
        //         Id = employee.Id,
        //         FullName = employee.FullName,
        //         Salary = employee.Salary
        //     };

        //Method Syntax
        // var result = _employeeRepository.GetEmployees().Select(employee => new
        // {
        //     Id = employee.Id,
        //     FullName = employee.FullName,
        //     Salary = employee.Salary
        // });
        //
        // foreach (var employee in result)
        // {
        //     Console.WriteLine(employee.Id + "\t" + employee.FullName + "\t" + employee.Salary);
        // }
        
        //Distinct
        
        //Query syntax

        // var result = (from employee in _employeeRepository.GetEmployees()
        //     select employee.Department).Distinct();

        //method syntax
        // var result = _employeeRepository.GetEmployees().Select(employee => employee.Department).Distinct();
        //
        // foreach (var department in result)
        // {
        //     Console.WriteLine(department);
        // }
        
        //first and firstOrDefault

        // var result = _employeeRepository.GetEmployees().Select(employee => new
        // {
        //     Id = employee.Id,
        //     FullName = employee.FullName,
        //     Department = employee.Department
        // }).FirstOrDefault(x => x.Department == "ADSKFD")??new {Id = -1, FullName="N/A", Department = "N/A"};;

       // Console.WriteLine(result.Id + "\t" + result.FullName + "\t" + result.Department);
       
       //single or singleordefault
       
       var result = _employeeRepository.GetEmployees().Select(employee => new
       {
           Id = employee.Id,
           FullName = employee.FullName,
           Department = employee.Department
       }).SingleOrDefault(x => x.Department == "AFAFA")??new {Id = -1, FullName="N/A", Department = "N/A"};
       
       Console.WriteLine(result.Id + "\t" + result.FullName + "\t" + result.Department);
    }

    private void OrderByDemo()
    {
        //Query Syntax
        // var result = from employee in _employeeRepository.GetEmployees()
        //     orderby employee.Salary descending, employee.FullName descending 
        //     select new
        //     {
        //         Id = employee.Id,
        //         FullName = employee.FullName,
        //         Salary = employee.Salary
        //     };
        
        //Method Syntax
        var result = _employeeRepository.GetEmployees().OrderByDescending(employee => employee.Salary)
            .ThenByDescending(employee=> employee.FullName)
            .Select(x => new
        {
            Id = x.Id,
            FullName = x.FullName,
            Salary = x.Salary
        });
        
        // var result = _employeeRepository.GetEmployees().OrderByDescending(employee => employee.Salary)
        //     .Select(x => new
        //     {
        //         Id = x.Id,
        //         FullName = x.FullName,
        //         Salary = x.Salary
        //     }).OrderBy(employee=> employee.FullName);
        
        foreach (var employee in result)
        {
            Console.WriteLine(employee.Id + "\t" + employee.FullName + "\t" + employee.Salary);
        }
    }

    private void WhereDemo()
    {
        //Query syntax
        // var result = from employee in _employeeRepository.GetEmployees()
        //     where employee.Salary > 6000
        //     select new
        //     {
        //         Id = employee.Id,
        //         FullName = employee.FullName,
        //         Salary = employee.Salary
        //     };
        
        //Method syntax

        var result = _employeeRepository.GetEmployees().Where(employee => employee.Salary > 6000)
            .Select(employee => new
            {
                Id = employee.Id,
                FullName = employee.FullName,
                Salary = employee.Salary
            });
        
        foreach (var employee in result)
        {
            Console.WriteLine(employee.Id + "\t" + employee.FullName + "\t" + employee.Salary);
        }
        
    }

    private void QuantifierDemo()
    {
        //Method syntax
        //var result = _employeeRepository.GetEmployees().All(employee => employee.Salary > 8000);
       
        var result = _employeeRepository.GetEmployees().Any(employee => employee.Salary > 8000);
        Console.WriteLine(result);
    }

    private void GroupByDemo()
    {
        //Query syntax
        // var result = from employee in _employeeRepository.GetEmployees()
        //     group employee by employee.Department;
        
        //result: IEnumerable<IGrouping<Key, Element>>
        // IT department --> 4 employee
        //     HR department --> 3 employee 

        //Method syntax
        var result = _employeeRepository.GetEmployees().GroupBy(employee => employee.Department);
        
        foreach (var group in result)
        {
            Console.WriteLine($"{group.Key} Department");
            foreach (var employee in group)
            {
                Console.WriteLine(employee.Id + "\t" +employee.FullName + "\t"+employee.Salary);
            }
        }
    }

    private void AggregationDemo()
    {
        //method syntax
        // var result = _employeeRepository.GetEmployees().Average(employee => employee.Salary);
        // Console.WriteLine(result);
        
        //get average salary by each department

        var result = _employeeRepository.GetEmployees().GroupBy(employee => employee.Department)
            .Select(employee => new
            {
                Department = employee.Key,
                AverageSalary =Math.Round( employee.Average(employee => employee.Salary), 2),
                TotalSalary = employee.Sum(employee => employee.Salary)
            });

        foreach (var employee in result)
        {
            Console.WriteLine(employee.Department+"\t" + employee.AverageSalary + "\t" + employee.TotalSalary);
        }
    }
    
    public void Run()
    {
       AggregationDemo();
    }
    
}