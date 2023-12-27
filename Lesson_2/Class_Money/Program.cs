namespace Class_Money
{
    class Program 
    {

        static void Main(string[] args)
        {
            var money = new Money
            {
                hrivna = 100,
                coin = 50
            };
            money.ShowSum();

            
        }
    }
}
