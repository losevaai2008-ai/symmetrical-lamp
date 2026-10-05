using PrimeCheckerApp;
using Xunit;

public class PrimeCheckerTests
{
    [Theory]
    [InlineData(2, true)]
    [InlineData(3, true)]
    [InlineData(4, false)]
    [InlineData(5, true)]
    [InlineData(9, false)]
    [InlineData(13, true)]
    [InlineData(25, false)]
    [InlineData(97, true)]
    public void IsPrime_ReturnsCorrectResult(int n, bool expected)
    {
        Assert.Equal(expected, PrimeChecker.IsPrime(n));
    }

    [Theory]                      // особые случаи из задания
    [InlineData(0, false)]
    [InlineData(1, false)]
    [InlineData(-7, false)]
    [InlineData(-100, false)]
    public void IsPrime_SpecialCases_AreNotPrime(int n, bool expected)
    {
        Assert.Equal(expected, PrimeChecker.IsPrime(n));
    }
}