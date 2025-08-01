class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        int x;
        bool isInteger = int.TryParse(input, out x);
        if (isInteger)
        {
            x = int.Parse(input);
            int y = (x > 5) ? 10 : x;
            Console.WriteLine(y);
        }
        else
        {
            Console.WriteLine("入力が整数ではありません。");
        }
    }
}