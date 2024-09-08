namespace CoreLib.Shapes;

public class Circle : IArea
{
    public static double CalcArea(params double[] values)
    {
        ArgumentNullException.ThrowIfNull(values);

        if (values.Length != 1)
            throw new ArgumentException("Invalid count of parameters.");

        double radius = values[0];
        return Math.PI * IArea.Square(radius);
    }
}
