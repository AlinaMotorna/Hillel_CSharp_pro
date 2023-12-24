using System;
using System.Xml.Linq;

public class Violin : Music_instrument
{

    public Violin() : base()
    {
		
		Show = "Скрипка";
		Desc = " струнний музичний смичковий інструмент. Має чотири струни, які настроюють на квінту (g, d1,a1,e2)";
		History = " З'явився у середині XVI століття";
        Console.WriteLine("Ведіть звук:");
        Sound = Console.ReadLine();
    }
    public void Instrument()
    {
        Console.WriteLine($"Нвзва - {Show}");
        Console.WriteLine($"Опис - {Desc}");
        Console.WriteLine($"історія - {History}");
        Console.WriteLine($"Звук - {Sound} ");
    }

}
