using System;

class MainClass
{
    static void Main(string[] args)
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int thirdNumber = int.Parse(Console.ReadLine());
        int fourthNumber = int.Parse(Console.ReadLine());

        RationalNumber a = new RationalNumber(firstNumber, secondNumber);
        RationalNumber b = new RationalNumber(thirdNumber, fourthNumber);

        Console.WriteLine("a in decimal is: {0:F2}", a.ToDecimal());
        Console.WriteLine("b in decimal is: {0:F2}", b.ToDecimal());

        Console.WriteLine("{0} + {1} = {2}", a, b, RationalNumber.Sum(a, b));
        Console.WriteLine("{0} - {1} = {2}", a, b, RationalNumber.Substraction(a, b));
        Console.WriteLine("{0} * {1} = {2}", a, b, RationalNumber.Product(a, b));
        Console.WriteLine("{0} / {1} = {2}", a, b, RationalNumber.Division(a, b));

        Console.WriteLine("Result of sum in decimal is: {0:F2}", RationalNumber.Sum(a, b).ToDecimal());
        Console.WriteLine("Result of substraction in decimal is: {0:F2}", RationalNumber.Substraction(a, b).ToDecimal());
        Console.WriteLine("Result of product in decimal is: {0:F2}", RationalNumber.Product(a, b).ToDecimal());
        Console.WriteLine("Result of devision in decimal is: {0:F2}", RationalNumber.Division(a, b).ToDecimal());
    }

    public static int NOK(int a, int b)
    {
        return (a * b) / NOD(a, b);
    }

    public static int NOD(int a, int b)
    {
        while (a != b)
        {
            if (a > b)
            {
                a -= b;
            }
            else
            {
                b -= a;
            }
        }
        return a;
    }

    public static void reduce(ref int a, ref int b)
    {
        int min = a < b ? a : b;
        while (a % min != 0 || b % min != 0)
        {
            min--;
        }
        a /= min;
        b /= min;
    }

}
class RationalNumber
{
    public int numerator, denominator;

    public RationalNumber(int num, int denom)
    {
        numerator = num;
        denominator = denom;
        MainClass.reduce(ref numerator, ref denominator);
    }
    public decimal ToDecimal()
    {
        return (decimal)numerator / denominator;
    }
    public override string ToString()
    {
        return string.Format("{0}/{1}", numerator, denominator);
    }

    public static RationalNumber Sum(RationalNumber a, RationalNumber b)
    {
        int denominator = MainClass.NOK(a.denominator, b.denominator);
        int numerator = a.numerator * (denominator / a.denominator) + b.numerator * (denominator / b.denominator);

        return new RationalNumber(numerator, denominator);
    }

    public static RationalNumber Substraction(RationalNumber a, RationalNumber b)
    {
        int denominator = MainClass.NOK(a.denominator, b.denominator);
        int numerator = a.numerator * (denominator / a.denominator) - b.numerator * (denominator / b.denominator);

        return new RationalNumber(numerator, denominator);
    }

    public static RationalNumber Product(RationalNumber a, RationalNumber b)
    {
        int numerator = a.numerator * b.numerator;
        int denominator = a.denominator * b.denominator;

        return new RationalNumber(numerator, denominator);
    }

    public static RationalNumber Division(RationalNumber a, RationalNumber b)
    {
        int denominator = a.denominator * b.numerator;
        int numerator = a.numerator * b.denominator;

        return new RationalNumber(numerator, denominator);
    }
}
