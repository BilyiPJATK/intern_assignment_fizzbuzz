using System.Text;

namespace intern_assignemtn;

public class FizzBuzzDetector
{
    
    public record FizzBuzzResult(string OutputString, int Count);
    
    public static FizzBuzzResult? getOverlappings(string input) {
        
        if (!IsValidInput(input))
            return null;
        
        int scoreCount = 0;
        int wordCount = 0;
        
        var output = new StringBuilder();
        var tempOutput = new StringBuilder();
        
        foreach (char c in input)
        {
            if (char.IsLetterOrDigit(c) || (c == '\'' && tempOutput.Length > 0)) {
                tempOutput.Append(c);
            }
            else {
                if (tempOutput.Length > 0) {
                    wordCount++;
                    AppendWordOrFizzBuzz(wordCount, tempOutput, output, ref scoreCount);
                    tempOutput.Clear();
                }

                output.Append(c);
            }
        }
        if (tempOutput.Length > 0) {
            wordCount++;
            AppendWordOrFizzBuzz(wordCount, tempOutput, output, ref scoreCount);
        }

        return new FizzBuzzResult(output.ToString(), scoreCount);
    }
    
    private static void AppendWordOrFizzBuzz(int wordCount, StringBuilder word, StringBuilder output, ref int scoreCount)
    {
        bool hasTrailingApostrophe = false;
        if (word.Length > 0 && word[word.Length - 1] == '\'')
        {
            word.Remove(word.Length - 1, 1);
            hasTrailingApostrophe = true;
        }
        
        if (wordCount % 15 == 0)
        {
            output.Append("FizzBuzz");
            scoreCount++;
        }
        else if (wordCount % 3 == 0)
        {
            output.Append("Fizz");
            scoreCount++;
        }
        else if (wordCount % 5 == 0)
        {
            output.Append("Buzz");
            scoreCount++;
        }
        else
        {
            output.Append(word);
        }
        
        if (hasTrailingApostrophe)
        {
            output.Append('\'');
        }
    }
    
    private static bool IsValidInput(string? input)
    {
        return input != null && input.Length >= 7 && input.Length <= 100;
    }
}