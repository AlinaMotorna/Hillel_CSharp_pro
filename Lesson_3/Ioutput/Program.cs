interface IOutput
{
    void Show()
    {
        string info = "info";
    }
    void Show(string info)
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
    void Show(string info) 
    {
        Console.WriteLine($"{myIntArray},{info} ");
    }
}
