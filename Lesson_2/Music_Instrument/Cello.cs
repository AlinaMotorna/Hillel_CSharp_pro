using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class Cello : Music_instrument
    {
        public Cello() : base()
        {
            
            Show = "Віолончель";
            Desc = "струнний смичковий музичний інструмент, родини скрипкових, басо-тенорового регістру. Музиканта, що грає на віолончелі називають віолончелі́стом.";
            History = "Поява віолончелі сягає початку XVI століття";
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

