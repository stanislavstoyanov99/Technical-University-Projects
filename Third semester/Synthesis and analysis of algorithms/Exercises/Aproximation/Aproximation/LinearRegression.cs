namespace Aproximation
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class LinearRegression
    {
        public double[] RegressionParameters { get; set; }

        public void GradientDescentTrain(
            Double learningRate,
            Int32 iterations,
            List<double> ys,
            List<double[]> xs)
        {
            if (xs.Count == 0 || xs[0].Length == 0)
            {
                return;
            }

            RegressionParameters = new double[xs[0].Length];

            do
            {
                var newRegressionParameters = RegressionParameters
                    .ToArray();

                for (var j = 0; j < RegressionParameters.Length; j++)
                {
                    double error = 0;

                    for (int i = 0; i < xs.Count; i++)
                    {
                        error += (ys[i] - Hipotesys(xs[i])) * xs[i][j];
                    }

                    newRegressionParameters[j] += learningRate * error;
                }

                RegressionParameters = newRegressionParameters;
            }
            while (iterations-- > 0);
        }

        public void GradientDescentIncrementalTrain(
            Double learningRate,
            Int32 iterations,
            List<double> ys,
            List<double[]> xs)
        {
            if (xs.Count == 0 || xs[0].Length == 0)
            {
                return;
            }

            RegressionParameters = new double[xs[0].Length];

            do
            {
                var newRegressionParameters = RegressionParameters
                    .ToArray();

                for (var j = 0; j < RegressionParameters.Length; j++)
                {
                    for (int i = 0; i < xs.Count; i++)
                    {
                        newRegressionParameters[j] +=
                            learningRate * (ys[i] - Hipotesys(xs[i])) * xs[i][j];
                    }
                }

                RegressionParameters = newRegressionParameters;
            }
            while (iterations-- > 0);
        }

        public double Hipotesys(params double[] xs)
        {
            double h = 0;

            for (int k = 0; k < xs.Length; k++)
            {
                h += xs[k] * RegressionParameters[k];
            }

            return h;
        }
    }
}
