using CoreLib.Shapes;

namespace WebAPI.OtherShapes;

public class ExternalShape : IArea
{
    public static double CalcArea(params double[] values)
    {
        ArgumentNullException.ThrowIfNull(values);

        if (values.Length != 1)
            throw new ArgumentException("Invalid count of parameters.");

        return values[0];
    }
}
