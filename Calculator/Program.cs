using System;

public class Class
{
    static public void Main()
    {
        double a, b, result;
        char sym;
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.WriteLine("Перше число:");
        a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Операнд:");
        sym = Convert.ToChar(Console.ReadLine());
        Console.WriteLine("Друге число:");
        b = Convert.ToDouble(Console.ReadLine());

        switch (sym)
        {
            case '+':
                result = a + b;
                Console.WriteLine($"=\n{result}");
                break;
            case '-':
                result = a - b;
                Console.WriteLine($"=\n{result}");
                break;
            case '*':
                result = a * b;
                Console.WriteLine($"=\n{result}");
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