namespace Market_
{
    class Program : Market
    {

        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Market market = new Market();
            market.Markets();
            Console.ReadKey();

        }
    }
}
