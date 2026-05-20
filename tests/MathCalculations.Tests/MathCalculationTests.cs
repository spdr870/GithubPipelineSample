using MathCalculations;

namespace MathCalculations.Tests;

[TestClass]
public class MathCalculationTests
{
    private readonly MathCalculation _calc = new();

    [TestMethod]
    [DataRow(new double[] { 1, 2, 3 }, 6.0)]
    [DataRow(new double[] { 0, 0, 0 }, 0.0)]
    [DataRow(new double[] { -1, -2, -3 }, -6.0)]
    [DataRow(new double[] { 10, 20, 30, 40 }, 100.0)]
    [DataRow(new double[] { 1.5, 2.5 }, 4.0)]
    public void Sum_ReturnsCorrectResult(double[] input, double expected)
    {
        var result = _calc.Sum(input);
        Assert.AreEqual(expected, result, 1e-10);
    }

    [TestMethod]
    [DataRow(2.0, 10.0, 1024.0)]
    [DataRow(3.0, 3.0, 27.0)]
    [DataRow(5.0, 0.0, 1.0)]
    [DataRow(4.0, 0.5, 2.0)]
    [DataRow(2.0, -1.0, 0.5)]
    public void Pow_ReturnsCorrectResult(double baseValue, double exponent, double expected)
    {
        var result = _calc.Pow(baseValue, exponent);
        Assert.AreEqual(expected, result, 1e-10);
    }
}
