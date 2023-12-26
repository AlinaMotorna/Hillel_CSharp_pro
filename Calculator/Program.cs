using System;

public class Class
{
    static public void Main()
    {
        double a, b, result;
        char sym;

        a = Convert.ToDouble(Console.ReadLine());

        sym = Convert.ToChar(Console.ReadLine());

        b = Convert.ToDouble(Console.ReadLine());

        switch (sym)
        {
            case '+':
                result = a + b;
                Console.WriteLine(result);
                break;
            case '-':
                result = a - b;
                Console.WriteLine(result);
                break;
            case '*':
                result = a * b;
                Console.WriteLine(result);
                break;
            case '/':
                if (b == 0)
                {
                    Console.WriteLine("Error");
                }
                else
                {
                    result = a / b;
                }
                break;
        }
    }
}