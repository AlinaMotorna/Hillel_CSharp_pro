using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Town
{
    public class City
    {
        public static int Plus(int zhitely, int zhitely2)
        {
            return zhitely + zhitely2;
        }
        public static int Minus(int zhitely, int zhitely2)
        {
            return zhitely - zhitely2;
        }
        public static string Rivno(int zhitely, int zhitely2)
        {
            if (zhitely == zhitely2)
            {
                return "Рівно";
            }
            else
                return "Не рівно";
        }
        public static string Proverka(int zhitely, int zhitely2)
        {
            if (zhitely > zhitely2) return "Більше";
            else
                return "Меньше";

        }
        public static string Nerivno(int zhitely, int zhitely2)
        {
            if (zhitely != zhitely2) return "Не рівно";
            else
                return "рівно";

        }
        public static string Nerivno1(int zhitely, int zhitely2)
        {
            if (zhitely.Equals(zhitely2)) return "Рівно";
            else
                return "Не рівно";

        }
    }
}