using System;

class RationalNumber
{
    private int numerator, denominator;
    public RationalNumber()
    {
        numerator = 0;
        denominator = 1;
    }
    public RationalNumber(int num, int denom)
    {
        numerator = num;
        denominator = denom;
    }
    public decimal ToDecimal()
    {
        return (decimal)numerator / denominator;
    }
    public override string ToString()
    {
        return string.Format("{0}/{1}", numerator, denominator);
    }

    static void Main(string[] args)
    {
        RationalNumber a = new RationalNumber();
        RationalNumber b = new RationalNumber(1, 4);
        RationalNumber c = null;
        Console.WriteLine("a={0}, decimal:{1}", a, a.ToDecimal());
        Console.WriteLine("b={0}, decimal: {1}", b, b.ToDecimal());
        if (c != null)
        {
            Console.WriteLine("c={0}, decimal:{1}", c, c.ToDecimal());
        }
    }
}
