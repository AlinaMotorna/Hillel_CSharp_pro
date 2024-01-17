using System.Xml.Linq;

namespace Stage_Play
{
    class Program : Stage_play
    {

        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Stage_play stage_play = new Stage_play();
            stage_play.Stage();

            Console.WriteLine("Пам'ять використана до збирання:       {0:N0}",GC.GetTotalMemory(false));
            GC.Collect();
            Console.WriteLine("Пам'ять використовується після повного збору:   {0:N0}", GC.GetTotalMemory(true));
            Console.ReadKey();
        }
        ~Program() 
        {
            Console.WriteLine("Закінчення"); 
        }
    }
}
