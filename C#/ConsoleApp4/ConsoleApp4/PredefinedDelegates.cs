namespace ConsoleApp4;

public class PredefinedDelegates
{
    //fibonacci sequence: 0, 1, 1, 2, 3, 5,.....

    private void Fibonacci(int length)
    {
        int a = 0, b = 1, c = 0;
        for (int i = 0; i<length; i++)
        {
            Console.WriteLine(a + " ");
            c = a + b;
            a = b;
            b = c;
        }
    }

    public void ActionExample()
    {
        // Action<int> fib = new Action<int>(Fibonacci);
        // fib(10);
        //first way: 
        // Action<int> fib = delegate(int length)
        // {
        //     int a = 0, b = 1, c = 0;
        //     for (int i = 0; i < length; i++)
        //     {
        //         Console.WriteLine(a + " ");
        //         c = a + b;
        //         a = b;
        //         b = c;
        //     }
        // };
        // fib(10);
        
        //Another way
        //lambda function

        Action<int> fib = length =>
        {
            int a = 0, b = 1, c = 0;
            for (int i = 0; i<length; i++)
            {
                Console.WriteLine(a + " ");
                c = a + b;
                a = b;
                b = c;
            }
        };
        fib(10);
    }

    public void PredicateDemo()
    {
        Predicate<string> palindrome = str =>
        {
            //abba
            int i = 0, j = str.Length-1;

            while (i < j)
            {
                if (str[i] != str[j])
                {
                    return false;
                }

                i++;
                j--;
            }

            return true;
        };
       Console.WriteLine(palindrome("abcd")); 
       Console.WriteLine(palindrome("abba"));
    }

    public void FuncDelegate()
    {
        Func<int, string> func = number =>
        {
           //factorial
           int f = 1;
           for (int i = number; i>1; i--)
           {
               f = f * i; 
           }

           return f.ToString();
        };
        Console.WriteLine( func(5));
    }
    
}