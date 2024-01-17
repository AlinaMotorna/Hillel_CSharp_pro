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
            Console.ReadKey();

        }
    }
}
