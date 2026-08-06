using NUnit.Framework;

[TestFixture]
public class CalculatorTest
{
    private Calculator1 cal;

    [SetUp]
    public void Setup()
    {
        cal = new Calculator1();
    }

    [Test]
    public void TestAdd()
    {
        Assert.That(cal.Add(10, 5), Is.EqualTo(15));
    }

    [Test]
    public void TestSubtract()
    {
       Assert.That(cal.Subtract(10, 5), Is.EqualTo(5));
    }

    [Test]
    public void TestMultiply()
    {
       Assert.That(cal.Multiply(10, 5), Is.EqualTo(50));
    }

    [Test]
    public void TestDivide()
    {
       Assert.That(cal.Divide(10, 5), Is.EqualTo(2));
    }

    [Test]
    public void TestDivideByZero()
    {
        Assert.Throws<DivideByZeroException>(() => cal.Divide(10, 0));
    }
}