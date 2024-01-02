namespace Credit_card
{
    public class Program : Creditcard
    {

        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Кредитна картка:");
            Console.WriteLine(Plus(25000, 2500));
            Console.WriteLine(Minus(55000, 2900));
            Console.WriteLine(Rivno(112, 112));
            Console.WriteLine(Proverka(9000, 2500));
            Console.WriteLine(Nerivno(63000, 6500));
            Console.WriteLine(Nerivno1(35000, 35000));
            Console.ReadLine();


        }
    }
}