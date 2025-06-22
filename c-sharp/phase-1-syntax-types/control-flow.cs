namespace phase_1_syntax_types;


public class ControlFlow
{
    public static string DescribeInput(object? input)
    {
        string result = input switch
        {
            int i when i < 0 => "Negative integer",
            int i when i > 0 => "Positive integer",
            string s when s.Length == 0 => "Empty string",
            string s when s.Length > 0  => $"String: {s}",
            null => "Null value",
            _ => "Unknown type"
        };
        return result;
    }
    public static string Ternary(int? input)
    {
        return input is null ? "Input is null" : input > 0 ? "Input is positive" : "Input is negative or zero";
    }
    public static string IfElse(int? input)
    {
        if (input is null)
        {
            return "Input is null";
        }
        else if (input > 0)
        {
            return "Input is positive";
        }
        else
        {
            return "Input is negative or zero";
        }
    }
    public static void IsPatternMatching(object? input)
    {
        if (input is int i)
        {
            Console.WriteLine($"Input is an integer: {i}");
        }
        else if (input is string s)
        {
            Console.WriteLine($"Input is a string: {s}");
        }
        else if (input is null)
        {
            Console.WriteLine("Input is null");
        }
        else
        {
            Console.WriteLine("Input is of an unknown type");
        }
    }

    public static void ForLoopExample(int count)
    {
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"Iteration {i + 1}");
        }

        foreach (var item in Enumerable.Range(0, count))
        {
            Console.WriteLine($"Foreach iteration {item + 1}");
        }
    }


}