using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Credit_card
{
    public class Creditcard
    {
        public static int Plus(int kartka, int kartka2)
        {
            return kartka + kartka2;
        }
        public static int Minus(int kartka, int kartka2)
        {
            return kartka - kartka2;
        }
        public static string Rivno(int cvc, int cvc2)
        {
            if (cvc == cvc2)
            {
                return "Рівно";
            }
            else
                return "Не рівно";
        }
        public static string Proverka(int kartka, int kartka2)
        {
            if (kartka > kartka2) return "Більше";
            else
                return "Меньше";

        }
        public static string Nerivno(int kartka, int kartka2)
        {
            if (kartka != kartka2) return "Не рівно";
            else
                return "рівно";

        }
        public static string Nerivno1(int kartka, int kartka2)
        {
            if (kartka.Equals(kartka2)) return "Рівно";
            else
                return "Не рівно";

        }
    }
}
