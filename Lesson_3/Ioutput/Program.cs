using Ioutput;
using System.Reflection;
namespace Ioutput
{
    public interface IOutput
    {
        public void Show()
        {
            string info = "info";
        }
        public void Show(string info) => Console.WriteLine(info);
    }
    public class MyArray : IOutput
    {
        int[] myIntArray = new int[5] { 1, 2, 3, 4, 5 };
        public void Show() => Console.WriteLine(myIntArray);
        public void Show(string info) => Console.WriteLine(info); 
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyArray rray = new MyArray();
            IOutput[] output = new IOutput[] { new MyArray()};
           
            Console.WriteLine("\n*Pet Walk*");
            rray.Show(info);

            Console.Read();
        }
    }


}
