// See https://aka.ms/new-console-template for more information

using ConsoleApp3;
using ConsoleApp3.Presentation;

// Console.WriteLine(GenericsDemo.AreEqual<int>(1,2));
// Console.WriteLine(GenericsDemo.AreEqual<double>(2.44, 4.344));
// Console.WriteLine(GenericsDemo.AreEqual<string>("antra", "antra"));
// Console.WriteLine(GenericsDemo.AreEqual<string>("antra", "12"));
// Console.WriteLine(GenericsDemo.AreEqual<int>(12, 12));

// Console.WriteLine(GenericsDemo<int>.AreEqual(1,2));
// Console.WriteLine(GenericsDemo<double>.AreEqual(2.44, 4.344));
// Console.WriteLine(GenericsDemo<string>.AreEqual("antra", "antra"));
// Console.WriteLine(GenericsDemo<string>.AreEqual("antra", "12"));
// Console.WriteLine(GenericsDemo<int>.AreEqual(12, 12));


// Customer ---> CustomerRepository -----> ManageCustomer

ManageCustomer manageCustomer = new ManageCustomer();
manageCustomer.Run();

Dictionary<int, string> dict= new Dictionary<int, string>();

