namespace CoreLib.Shapes;

public static class AreaManager
{
    public delegate double CalcAreaFunc(params double[] values);

    static AreaManager()
    {
        Type areaType = typeof(IArea);
        AreaCalcs = AppDomain.CurrentDomain.GetAssemblies()
            .SelectMany(assembly => assembly.GetTypes())
            .Where(type => areaType.IsAssignableFrom(type) && type != areaType)
            .ToDictionary(type => type.Name, type => (CalcAreaFunc)type.GetMethod("CalcArea")!.CreateDelegate(typeof(CalcAreaFunc)));
    }

    public static Dictionary<string, CalcAreaFunc> AreaCalcs { get; }
}
