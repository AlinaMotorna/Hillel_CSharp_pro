
namespace Town
{
    public class Program : City
    {

        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Жителі:");
            Console.WriteLine(Plus(30000, 2300));
            Console.WriteLine(Minus(30000, 2000));
            Console.WriteLine(Rivno(30000, 30000));
            Console.WriteLine(Proverka(30000, 2300));
            Console.WriteLine(Nerivno(30000, 2300));
            Console.WriteLine(Nerivno1(30000, 30000));
            Console.ReadLine();


        }
    }
}
