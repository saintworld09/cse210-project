// Program.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating fractions using the constructors
        Fraction fraction1 = new Fraction(); // 1/1
        Fraction fraction2 = new Fraction(6); // 6/1
        Fraction fraction3 = new Fraction(6, 7); // 6/7
        Fraction fraction4 = new Fraction(3, 4); // 3/4
        Fraction fraction5 = new Fraction(1, 3); // 1/3

        // Displaying the fractions and their decimal values
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());

        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());

        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());

        Console.WriteLine(fraction4.GetFractionString());
        Console.WriteLine(fraction4.GetDecimalValue());

        Console.WriteLine(fraction5.GetFractionString());
        Console.WriteLine(fraction5.GetDecimalValue());
    }
}
