using ConsoleApp4.DataModel;
using ConsoleApp4.Repository;

namespace ConsoleApp4.Presentation;

public class ManageEmployee
{
    private EmployeeRepository _employeeRepository = new EmployeeRepository();

    public void Print()
    {
        //List<Employee> employees = _employeeRepository.Search(employee => employee.City == "Chicago");
        List<Employee> employees = _employeeRepository.Search(employee => employee.Department == "IT");
     
        // foreach (var employee in employees)
        // {
        //     Console.WriteLine(employee.Id + "\t" + employee.FullName+ "\t"+ employee.City );
        // }
        foreach (var employee in employees)
        {
            Console.WriteLine(employee.Id + "\t" + employee.FullName+ "\t"+ employee.City );
        }
    }
    
    // Func<int, string> func = number =>
    // {
    //     //factorial
    //     int f = 1;
    //     for (int i = number; i>1; i--)
    //     {
    //         f = f * i; 
    //     }
    //
    //     return f.ToString();
    // };
    // Console.WriteLine( func(5));

}