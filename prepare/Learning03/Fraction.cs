// Fraction.cs
using System;

public class Fraction
{
    // Private attributes for numerator and denominator
    private int numerator;
    private int denominator;

    // Constructor with no parameters
    public Fraction()
    {
        numerator = 1;
        denominator = 1;
    }

    // Constructor with one parameter for the numerator, denominator is set to 1
    public Fraction(int numerator)
    {
        this.numerator = numerator;
        denominator = 1;
    }

    // Constructor with two parameters for numerator and denominator
    public Fraction(int numerator, int denominator)
    {
        this.numerator = numerator;
        this.denominator = denominator;
    }

    // Getter for numerator
    public int GetNumerator()
    {
        return numerator;
    }

    // Setter for numerator
    public void SetNumerator(int numerator)
    {
        this.numerator = numerator;
    }

    // Getter for denominator
    public int GetDenominator()
    {
        return denominator;
    }

    // Setter for denominator
    public void SetDenominator(int denominator)
    {
        if (denominator != 0)
        {
            this.denominator = denominator;
        }
        else
        {
            Console.WriteLine("Denominator cannot be zero.");
        }
    }

    // Method to return the fraction as a string
    public string GetFractionString()
    {
        return $"{numerator}/{denominator}";
    }

    // Method to return the decimal value
    public double GetDecimalValue()
    {
        return (double)numerator / denominator;
    }
}
