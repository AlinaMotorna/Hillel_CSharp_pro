using System;

public class Ukulele : Music_instrument
{
    public Ukulele() : base()
    {

        Show = "Укулеле";
        Desc = "невеликий інструмент, що схожий на гітару. Був завезений на Гаваї португальськими іммігрантами з Мадейри. На початку 20 століття інструмент набув великої популярності у Сполучених Штатах Америки, звідки поширився і здобув популярність на міжнародному рівні.";
        History = "Перші прообрази укулеле з'явилися в Європі в середині 15 століття";
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
