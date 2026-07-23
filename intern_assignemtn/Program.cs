namespace intern_assignemtn;

class Program
{
    static void Main(string[] args)
    {
        string input =
            "Mary had a little lamb\nLittle lamb, little lamb\nMary had a little lamb\nIt's fleece was white as snow";
        var result = FizzBuzzDetector.getOverlappings(input);
        
        if (result != null)
        {
            Console.WriteLine(result.OutputString);
            Console.WriteLine();
            Console.WriteLine($"count: {result.Count}");
        }
    }
}