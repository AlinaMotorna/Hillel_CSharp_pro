﻿using Ioutput;
using System.Reflection;
namespace Ioutput
{
    interface IOutput
    {
        public void Show()
        {
            string info = "info";
        }
        public void Show(string info)
        {
            Console.WriteLine(info);
        }
    }
    class MyArray : IOutput
    {
        int[] myIntArray = new int[5] { 1, 2, 3, 4, 5 };
        public void Show()
        {
            Console.WriteLine(myIntArray);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            static void Show(string info)
            {
                IOutput output = new MyArray();
                output.Show(info);
            }
        }
    }

}