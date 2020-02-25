namespace Aproximation
{
    using System.IO;
    using System.Linq;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            using var reader = new StreamReader(@"..\..\..\Data\data.csv");

            List<double> age = new List<double>();
            List<double> education = new List<double>();
            List<double> amount = new List<double>();
            List<double> perc = new List<double>();

            var line = reader.ReadLine();

            while (!reader.EndOfStream)
            {
                line = reader.ReadLine();
                var values = line
                    .Split(';')
                    .Select(double.Parse)
                    .ToArray();

                age.Add(values[0]);
                education.Add(values[1]);
                amount.Add(values[2]);
                perc.Add(values[3]);
            }

            LinearRegression linearRegression = new LinearRegression();

            List<double[]> xs = new List<double[]>();

            double[] ageXs = age
                .ToArray();

            double[] educationXs = education
                .ToArray();

            double[] amountXs = amount
                .ToArray();

            xs.Add(ageXs);
            xs.Add(educationXs);
            xs.Add(amountXs);

            linearRegression.GradientDescentTrain(0.000001, 30, perc, xs);
        }
    }
}
