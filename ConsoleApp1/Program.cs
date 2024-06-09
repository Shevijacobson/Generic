using ConsoleApp1;

internal class Program
{
    private static void Main(string[] args)
    {
      
        SwapList<string> names = new SwapList<string> { "shevi", "batshi", "chani", "dina" };
       
        names.Swap(1,2);
        Console.WriteLine(string.Join(", ", names));


    }
}