namespace ConsoleApp4;

public class NumberException: Exception
{
    public override string Message
    {
        get
        {
            return "Number cannot be negative";
        }
    }

    // public NumberException(string message) : base(message)
    // {
    //     
    // }
    
    
}