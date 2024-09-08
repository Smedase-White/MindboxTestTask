namespace CoreLib.Shapes;

public interface IArea
{
    public static abstract double CalcArea(params double[] values);

    public static double Square(double value) => value * value;
}
