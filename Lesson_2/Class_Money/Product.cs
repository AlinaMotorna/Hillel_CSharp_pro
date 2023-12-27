using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Money
{
    public class Product 
    {
        public string Name;
        public Money Moneysum { get; set; }
        public void Showproduct() 
        {
            Console.WriteLine($"product {Name} and price:{Moneysum.Hrivnapart} grn {Moneysum.Coinpart} coins");
        }
    }
    
}
