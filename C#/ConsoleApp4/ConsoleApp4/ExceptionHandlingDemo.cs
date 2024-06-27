namespace ConsoleApp4;

public class ExceptionHandlingDemo
{
    public int Divide(int a, int b)
    {
        return a / b;
    }

    public int Calculate(int a, int b, string operation)
    {
        if (operation == "/")
        {
           return Divide(a, b);
        }
        else
        {
            throw new ArgumentOutOfRangeException();
        }
    }
}