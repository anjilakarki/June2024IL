// See https://aka.ms/new-console-template for more information

// Console.WriteLine("Hello, World!");

using ConsoleApp2;

// Customer a = new Customer();
//
// Customer c = new Customer(1, "Smith", "abc@gmail.com");
// //c.CustomerName = "Smith";
// Console.WriteLine(c.CustomerName);
//
// Customer d = new Customer(2, "Adam", "adam123@gmail.com", "1234567");

FullTimeEmployee fullTimeEmployee = new FullTimeEmployee(1, 1200);
fullTimeEmployee.PerformWork();

PartTimeEmployee pte = new PartTimeEmployee(2);
pte.PerformWork();

Manager m = new Manager(3, 5000);
m.PerformWork();

//Addittion addition = new Addittion();

// Console.WriteLine(addition.AddNumbers(1, 2));
// Console.WriteLine(addition.AddNumbers(1.2, 10.323));
// Console.WriteLine(addition.AddNumbers(4, 5,2));

Console.WriteLine(Addittion.AddNumbers(1, 2));
Console.WriteLine(Addittion.AddNumbers(1.2, 10.323));
Console.WriteLine(Addittion.AddNumbers(4, 5,2));

int a = 3; 
Console.WriteLine(a.EvenOrOdd());

EmployeeRepository _employeeRepository = new EmployeeRepository();
_employeeRepository.CreateEmployee(new FullTimeEmployee(1, 1500));
_employeeRepository.CreateEmployee(new PartTimeEmployee(2));
_employeeRepository.CreateEmployee(new Manager(3, 2000));
List<Employee> employees=  _employeeRepository.GetAllEmployees();

foreach (var employee in employees)
{
    Console.WriteLine(employee.Id);
}























