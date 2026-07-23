namespace intern_assignemtn.Tests;
using Xunit;

public class FizzBuzzDetectorTests
{
    [Fact]
    public void Test_AssignmentExample_ReturnsExpectedOutputAndCount()
    {
        string input = "Mary had a little lamb\nLittle lamb, little lamb\nMary had a little lamb\nIt's fleece was white as snow";
        
        var result = FizzBuzzDetector.getOverlappings(input);

        Assert.NotNull(result);
        Assert.Equal(9, result.Count);
        Assert.Contains("FizzBuzz fleece was Fizz as Buzz", result.OutputString);
    }

    [Fact]
    public void Test_ShortInput_ReturnsNull()
    {
        string input = "Short"; // length < 7
        var result = FizzBuzzDetector.getOverlappings(input);
        Assert.Null(result);
    }

    [Fact]
    public void Test_LongInput_ReturnsNull()
    {
        string input = new string('a', 101); // length > 100
        var result = FizzBuzzDetector.getOverlappings(input);
        Assert.Null(result);
    }

    [Fact]
    public void Test_NullInput_ReturnsNull()
    {
        var result = FizzBuzzDetector.getOverlappings(null!);
        Assert.Null(result);
    }

    [Fact]
    public void Test_FifteenthWord_ReplacesWithFizzBuzz()
    {
        // Exactly 15 distinct words separated by spaces
        string input = "one two three four five six seven eight nine ten eleven twelve thirteen fourteen fifteen";
        
        var result = FizzBuzzDetector.getOverlappings(input);

        Assert.NotNull(result);
        Assert.EndsWith("FizzBuzz", result.OutputString);
    }
    
    [Fact]
    public void Test_ApostrophesAndSingleQuotes_HandledCorrectly()
    {
        // 1. "It's" should be treated as 1 single word.
        // 2. "'programing'" should preserve quotes around the word without swallowing them into Fizz/Buzz.
        string input = "It's 'programing' task, that is simple";

        var result = FizzBuzzDetector.getOverlappings(input);

        Assert.NotNull(result);
        
        Assert.Contains("It's 'programing' Fizz, that Buzz Fizz", result.OutputString);
    }
}