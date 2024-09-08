using Microsoft.AspNetCore.Mvc;

using WebAPI.Controllers;

namespace UnitTests;

public class ShapeControllerTests
{
    [Fact]
    public void CorrectCircleAreaCalculate()
    {
        // Arrange
        ShapeController controller = new();
        string shape = "Circle";
        double[] values = [1];

        // Act
        ContentResult? result = controller.CalcArea(shape, values) as ContentResult;

        // Assert
        Assert.Equal($"Shape area: {Math.PI}", result!.Content);
    }

    [Fact]
    public void ExceptionWhenCircleWrongCountParameters()
    {
        // Arrange
        ShapeController controller = new();
        string shape = "Circle";
        double[] values = [1, 2];

        // Act
        ContentResult? result = controller.CalcArea(shape, values) as ContentResult;

        // Assert
        Assert.Equal("Invalid count of parameters.", result!.Content);
    }

    [Fact]
    public void CorrectTriangleAreaCalculate()
    {
        // Arrange
        ShapeController controller = new();
        string shape = "Triangle";
        double[] values = [1, 1, 1];

        // Act
        ContentResult? result = controller.CalcArea(shape, values) as ContentResult;

        // Assert
        Assert.Equal($"Shape area: {Math.Sqrt(3) / 4}", result!.Content);
    }

    [Fact]
    public void ExceptionWhenTriangleWrongCountParameters()
    {
        // Arrange
        ShapeController controller = new();
        string shape = "Triangle";
        double[] values = [1];

        // Act
        ContentResult? result = controller.CalcArea(shape, values) as ContentResult;

        // Assert
        Assert.Equal("Invalid count of parameters.", result!.Content);
    }

    [Fact]
    public void ExceptionWhenTriangleDoesNotExist()
    {
        // Arrange
        ShapeController controller = new();
        string shape = "Triangle";
        double[] values = [1, 1, 5];

        // Act
        ContentResult? result = controller.CalcArea(shape, values) as ContentResult;

        // Assert
        Assert.Equal("Invalid parameters. Triangle doesn't exist.", result!.Content);
    }

    [Fact]
    public void CorrectExternalShapeCalculate()
    {
        // Arrange
        ShapeController controller = new();
        string shape = "ExternalShape";
        double[] values = [1];

        // Act
        ContentResult? result = controller.CalcArea(shape, values) as ContentResult;

        // Assert
        Assert.Equal($"Shape area: {1}", result!.Content);
    }

    [Fact]
    public void ExceptionWhenShapeDoesNotExist()
    {
        // Arrange
        ShapeController controller = new();
        string shape = "NotExistedShape";
        double[] values = [1];

        // Act
        ContentResult? result = controller.CalcArea(shape, values) as ContentResult;

        // Assert
        Assert.Equal($"Shape doesn't exist.", result!.Content);
    }
}
