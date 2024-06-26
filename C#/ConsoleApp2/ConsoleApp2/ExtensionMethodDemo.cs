namespace ConsoleApp2;

public static class ExtensionMethodDemo
{
    public static string EvenOrOdd(this int a)
    {
        if (a % 2 == 0)
        {
            return "Even";
        }
        else
        {
            return "Odd";
        }
    }
}