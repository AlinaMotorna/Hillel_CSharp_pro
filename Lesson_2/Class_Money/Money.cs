using System;

public class Money
{
    
    int Hrivna;
    int Copiyki;
    public Money()
	{
        Hrivna = 0;
        Copiyki = 0;
    }
    public Money(int H, int C)
    {
        Hrivna = H;
        Copiyki = C % 100;
    }
    public void howmuch()
    {
        Console.WriteLine("У вас " + Hrivna + " рублей " + Copiyki + " копеек");
    }
}
