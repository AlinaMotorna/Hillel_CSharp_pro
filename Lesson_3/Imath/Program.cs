public class Program
{
    interface IMath
    {
        int Max() {  return int.MaxValue; }
        int Min() {  return int.MinValue; }
        float Avg() {  return 0; }
    }
    class MyArray : IMath
    {
        int[] myIntArray = new int[5] { 1, 2, 3, 4, 5 };
        public void Show()
        {
            Console.WriteLine(myIntArray);
        }
    }
    static void Main(string[] args)
    {
        MyArray myArray = new MyArray();
        myArray.Show(myIntArray);
    }


}
