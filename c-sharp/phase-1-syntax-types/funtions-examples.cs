using System.Runtime.InteropServices.Marshalling;

namespace phase_1_syntax_types;

class Function_Examples
{
    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static int Subtract(int a, int b)
    {
        return a - b;
    }

    public static int Multiply(int a, int b)
    {
        return a * b;
    }

    public static double Divide(int a, int b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Division by zero is not allowed.");
        }
        return (double)a / b;
    }

    // Ref, in, Out, and Params examples
    public static void ModifyValue(ref int value)
    {
        value += 10; // Modifies the original value
    }
    public static void OutParameterExample(out int result)
    {
        result = 42; // Assigns a value to the out parameter
    }
    public static void InParameterExample(in int value)
    {
        // value = 100; // This would cause a compile-time error because 'in' parameters are read-only
        Console.WriteLine($"In parameter value: {value}");
    }
    public static int Sum(params int[] numbers)
    {
        return numbers.Sum();
    }
    // Practice
    public static void DoWork(ref int a, out int b)
    {
        a += 5; // Modifies the original value
        b = a * 2; // Assigns a value to the out parameter
    }
    
}
