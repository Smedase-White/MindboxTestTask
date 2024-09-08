using CoreLib.Shapes;

namespace UnitTests;

public class ShapeTests
{
    [Fact]
    public void CorrectCircleAreaCalculate()
    {
        // Arrange
        double[] values = [1];

        // Act
        double area = Circle.CalcArea(values);

        // Assert
        Assert.Equal(Math.PI, area);
    }

    [Fact]
    public void ExceptionWhenCircleWrongCountParameters()
    {
        // Arrange
        double[] values = [1, 2];

        // Act & Assert
        Assert.Throws<ArgumentException>(() => Circle.CalcArea(values));
    }

    [Fact]
    public void CorrectTriangleAreaCalculate()
    {
        // Arrange
        double[] values = [1, 1, 1];

        // Act
        double area = Triangle.CalcArea(values);

        // Assert
        Assert.Equal(Math.Sqrt(3) / 4, area);
    }

    [Fact]
    public void ExceptionWhenTriangleWrongCountParameters()
    {
        // Arrange
        double[] values = [1];

        // Act & Assert
        Assert.Throws<ArgumentException>(() => Triangle.CalcArea(values));
    }

    [Fact]
    public void ExceptionWhenTriangleDoesNotExist()
    {
        // Arrange
        double[] values = [1, 1, 5];

        // Act & Assert
        Assert.Throws<ArgumentException>(() => Triangle.CalcArea(values));
    }
}
