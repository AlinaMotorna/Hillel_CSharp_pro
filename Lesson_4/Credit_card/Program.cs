using Credit_card;

namespace e_mployee
{
    public class Program : Creditcard
    {

        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Кредитна картка:");
            Console.WriteLine(Plus(35000, 2500));
            Console.WriteLine(Minus(35000, 2500));
            Console.WriteLine(Rivno(35000, 2500));
            Console.WriteLine(Proverka(35000, 2500));
            Console.WriteLine(Nerivno(35000, 2500));
            Console.WriteLine(Nerivno1(35000, 2500));
            Console.ReadLine();


        }
    }
}