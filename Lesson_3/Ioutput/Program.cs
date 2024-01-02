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
            Console.Write(info);
        }
    }
    class MyArray : IOutput
    {
        int[] myIntArray = new int[5] { 1, 2, 3, 4, 5 };
        public void Show()
        {
            Console.Write(myIntArray);
        }
        public void Show(string info)
        {
            IOutput output = new MyArray();
            output.Show(info);
        }
    }
}