// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

using System;
using System.Data;

class Calculator
{
    public static object Calculate(string expression)
    {
        try
        {
            // Use DataTable to compute the expression
            DataTable table = new DataTable();
            var result = table.Compute(expression, string.Empty);
            return result;
        }
        catch (Exception ex)
        {
            var error = $"Errors: {ex.Message}";
            return error;
        }
    }
}

Console.WriteLine(Calculate("5 + 3 * (2 - 8)"));   // -11
Console.WriteLine(Calculate("10 / 2 + 6"));       // 11
Console.WriteLine(Calculate("invalid expression")); // Error

