namespace Music_Instrumental
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Violin violin = new Violin();
            violin.Instrument();

            Ukulele ukulele = new Ukulele();
            ukulele.Instrument();

            Trombone trombone = new Trombone();
            trombone.Instrument();

            Cello cello = new Cello();
            cello.Instrument();
        }
    }
}