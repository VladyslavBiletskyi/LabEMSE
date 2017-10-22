using System;
using MathNet.Numerics.LinearRegression;
namespace EmSELab1.Processors
{
    public class RegressionProcessor
    {
        public static Tuple<double, double> FitPoints(float[] xs, float[] ys)
        {
            return SimpleRegression.Fit(Array.ConvertAll(xs, x => (double)x), Array.ConvertAll(ys, y => (double)y));
        }
    }
}
