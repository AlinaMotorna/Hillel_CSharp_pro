namespace Class_Money
{
    class Program 
    {

        static void Main(string[] args)
        {
            
            var Myprod = new Product
            {
                Moneysum = new Money
                {
                    hrivna = 122,
                    coin = 30
                },
                Name = "Apple"
            };
            Console.WriteLine(Myprod.Name);
            Myprod.Showproduct();
        }
    }
}
