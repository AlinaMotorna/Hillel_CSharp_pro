using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage_Play
{
    internal class Stage_play
    {
            string name = "тіні забутих предків";
            string autor = "Михайло Михайлович Коцюбинский";
            string genre = "філософія";
            int year = 1911;
        public void Stage()
        {
            
            Console.WriteLine($"Назва п'єси: {name}");
            Console.WriteLine($"Автор: {autor}");
            Console.WriteLine($"Жанр: {genre}");
            Console.WriteLine($"Рік написання: {year}");
        }
    }
}
