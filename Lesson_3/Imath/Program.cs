public class Program
{
    interface IMath
    {
        int Max() {  return int.MaxValue; }
        int Min() {  return int.MinValue; }
        float Avg() {  return 0; }
        bool Search(int valueToSearch) {  return false; }
    }
    class MyArray : IMath
    {
        int[] myIntArray = new int[5] { 1, 2, 3, 4, 5 };
        public void Show()
        {
            Console.WriteLine(myIntArray);
        }
    }
   
}
