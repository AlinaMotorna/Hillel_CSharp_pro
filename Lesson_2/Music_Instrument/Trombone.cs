using System;

public class Trombone : Music_instrument
{
    public Trombone() : base()
    {

        Show = "Тромбон";
        Desc = " музичний інструмент сімейства мідних духових. Складається з двічі зігнутої циліндричної труби, загальною довжиною близько 300 см, діаметром — від 15 мм";
        History = "тромбон з'явився ще у XV столітті";
        Console.WriteLine("Ведіть звук:");
        Sound = Console.ReadLine();

    }
    public void Instrument()
    {
        Console.WriteLine($"Назва - {Show}");
        Console.WriteLine($"Опис - {Desc}");
        Console.WriteLine($"історія - {History}");
        Console.WriteLine($"Звук - {Sound} ");
    }
}
