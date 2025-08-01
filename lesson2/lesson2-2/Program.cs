class Program
{
    static bool Echo(string message)
    {
        Console.WriteLine(message);
        return true;
    }
    static void Main()
    {
        Console.WriteLine("ショートサーキットなしの例");
        var x = Echo("a") | Echo("b");
        Console.WriteLine("ショートサーキットあり");
        var y = Echo("c") || Echo("d");
    }
}