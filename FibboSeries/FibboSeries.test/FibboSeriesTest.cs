using NUnit.Framework;

namespace FibboSeries.test;

[TestFixture]
public class FibboSeriesTest
{
    private Fibbonacci_Series.FibboSeries fibboSeries;

    [SetUp]
    public void Setup()
    {
        fibboSeries = new Fibbonacci_Series.FibboSeries();
    }   

    [Test]
    public void GetFibbonacci_WhenCalled_ReturnsFibbonacciSeries()
    {
        // Arrange
        var number = 5;

        // Act
        var result = fibboSeries.GetFibbonacci(number);

        // Assert
        Assert.That(result, Is.EqualTo(new List<int> { 1, 1, 2, 3, 5 }));
    }

    [Test]  
    public void GetFibbonacci_WhenCalledWithZeroOrLess_ThrowsArgumentException()
    {
        // Arrange
        var number = 0;

        // Act
        // Assert
        Assert.Throws<ArgumentException>(() => fibboSeries.GetFibbonacci(number));
    }

    [Test]  
    public void GetFibbonacci_WhenCalledWithOne_ReturnsFibbonacciSeries()
    {
        // Arrange
        var number = 1;

        // Act
        var result = fibboSeries.GetFibbonacci(number);

        // Assert
        Assert.That(result, Is.EqualTo(new List<int> { 1 }));
    }

    [Test]  

    public void GetFibbonacci_WhenCalledWithSix_ReturnsFibbonacciSeries()
    {
        // Arrange
        var number = 6;

        // Act
        var result = fibboSeries.GetFibbonacci(number);

        // Assert
        Assert.That(result, Is.EqualTo(new List<int> { 1, 1, 2, 3, 5, 8 }));
        Assert.That(result, Does.Contain(3));
        Assert.That(result,Does.Not.Contain(4));
        Assert.That(result.Count, Is.EqualTo(6));

    }

}
