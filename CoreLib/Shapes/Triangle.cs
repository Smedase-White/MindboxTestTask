namespace CoreLib.Shapes;

public class Triangle : IArea
{
    public static double CalcArea(params double[] values)
    {
        ArgumentNullException.ThrowIfNull(values);

        if (values.Length != 3)
            throw new ArgumentException("Invalid count of parameters.");

        if (values[0] > values[1])
            (values[1], values[0]) = (values[0], values[1]);
        if (values[1] > values[2])
            (values[2], values[1]) = (values[1], values[2]);

        if (values[0] + values[1] <= values[2])
            throw new ArgumentException("Invalid parameters. Triangle doesn't exist.");

        if (IArea.Square(values[0]) + IArea.Square(values[1]) == IArea.Square(values[2]))
            return values[0] * values[1];

        double p = (values[0] + values[1] + values[2]) / 2;
        return Math.Sqrt(p * (p - values[0]) * (p - values[1]) * (p - values[2]));
    }
}
