using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Money
{
    public class Money
    {
        public int hrivna;
        public int coin;

        public int Hrivnapart { 
            get
            { 
                return hrivna;
            }
            set 
            {
                
                if (value > 0) 
                hrivna = value;
            } 
        }
        public int Coinpart
        {
            get
            {
                return coin;
    
            }
            set
            {
                if (value > 0 && value < 100)
                {
                    coin = value;
                }
            }
        }
        public void ShowSum()
        {
            Console.WriteLine($"{Hrivnapart} grn {Coinpart} coins");
        }
        public void SetSum(int coins, int hrivns) 
        {
            Hrivnapart = hrivns;
            Coinpart = coins;
        }

    }
    
}
