using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Market_
{
    public class Market : IDisposable
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
        public void Dispose()
        {
            Console.WriteLine($"{name} has been disposed");
            Console.WriteLine($"{adress} has been disposed");
            Console.WriteLine($"{type} has been disposed");
            GC.SuppressFinalize(this);
        }
    }
}
