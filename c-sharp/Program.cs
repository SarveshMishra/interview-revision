using phase_1_syntax_types;
namespace c_sharp;
class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");
        // Example usage of the DescribeInput method
        Console.WriteLine(ControlFlow.DescribeInput(42));          // Positive integer
        Console.WriteLine(ControlFlow.DescribeInput(-1));          // Negative integer
        Console.WriteLine(ControlFlow.DescribeInput("Hello, World"));     // String: Hello, World
        Console.WriteLine(ControlFlow.DescribeInput(""));          // Empty string
        Console.WriteLine(ControlFlow.DescribeInput(null));        // Null value
        Console.WriteLine(ControlFlow.DescribeInput(3.14));        // Unknown type

        // Example usage of the Ternary method
        Console.WriteLine(ControlFlow.Ternary(5));                // Input is positive
        Console.WriteLine(ControlFlow.Ternary(-3));               // Input is negative or zero
        Console.WriteLine(ControlFlow.Ternary(null));             // Input is null
        // Example usage of the IfElse method
        Console.WriteLine(ControlFlow.IfElse(10));                // Input is positive
        Console.WriteLine(ControlFlow.IfElse(-5));                // Input is negative or zero
        Console.WriteLine(ControlFlow.IfElse(null));              // Input is null
        // Example usage of the IsPatternMatching method
        ControlFlow.IsPatternMatching(100);                       // Input is an integer: 100
        ControlFlow.IsPatternMatching("Hello");                   // Input is a string: Hello
        ControlFlow.IsPatternMatching(null);                      // Input is null
        ControlFlow.IsPatternMatching(3.14);                      // Input is of an unknown type
        // Example usage of the ForLoopExample method
        ControlFlow.ForLoopExample(5);                            // Prints numbers 0 to 4
        int a = 10;
        Function_Examples.DoWork(ref a, out int b);
        Console.WriteLine($"a: {a}, b: {b}");
    }
}

