using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_
{
    internal class Market
    {
        string name = "Сільпо";
        string adress = "Вул...";
        string type = "Супермаркет";
        public void Markets()
        {
            Console.WriteLine($"Назва: {name}");
            Console.WriteLine($"Адреса: {adress}");
            Console.WriteLine($"Тип: {type}");
        }
    }
}
