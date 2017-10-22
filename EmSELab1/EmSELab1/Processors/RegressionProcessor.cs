using System;
namespace EmSELab1.Processors
{
    public class RegressionProcessor
    {
        public static Tuple<double, double> FitPoints(float[] xs, float[] ys)
        {
            return MathNet.Numerics.Fit.Line(Array.ConvertAll(xs, x => (double)x), Array.ConvertAll(ys, y => (double)y));
        }
    }
}
