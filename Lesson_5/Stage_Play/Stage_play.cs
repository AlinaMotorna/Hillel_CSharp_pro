using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Stage_Play
{
    internal class Stage_play : IDisposable
    {

            string name = "тіні забутих предків";
            string autor = "Михайло Михайлович Коцюбинський";
            string genre = "філософія";
            int year = 1911;
        public void Stage()
        {
            Console.WriteLine($"Назва п'єси: {name}");
            Console.WriteLine($"Автор: {autor}");
            Console.WriteLine($"Жанр: {genre}");
            Console.WriteLine($"Рік написання: {year}");
        }

        public void Dispose()
        {
            Console.WriteLine($"{name} has been disposed");
            Console.WriteLine($"{autor} has been disposed");
            Console.WriteLine($"{genre} has been disposed");
            Console.WriteLine($"{year} has been disposed");
        }
        ~Stage_play() => Console.WriteLine("Закінчення");
    }
}
