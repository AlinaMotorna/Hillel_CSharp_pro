using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_mployee
{
    
    public class Employee
    {
       public static int Plus(int zarplata, int zarplata2)
        {
            return zarplata + zarplata2;
        }
        public static int Minus(int zarplata, int zarplata2)
        {
            return zarplata - zarplata2;
        }
        public static string Rivno(int zarplata, int zarplata2)
        {
            if (zarplata == zarplata2) 
            {
                return "Рівно";
            }
            else
            return "Не рівно";
        }
        public static string Proverka(int zarplata, int zarplata2)
        {
            if (zarplata > zarplata2) return "Більше";
            else
            return "Меньше";

        }
        public static string Nerivno(int zarplata, int zarplata2)
        {
            if (zarplata != zarplata2) return "Не рівно";
            else
                return "рівно";

        }
        public static string Nerivno1(int zarplata, int zarplata2)
        {
            if (zarplata.Equals (zarplata2)) return "Рівно";
            else
                return "Не рівно";

        }
    }
}
