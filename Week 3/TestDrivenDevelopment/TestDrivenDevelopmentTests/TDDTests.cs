using TestDrivenDevelopmentApp;
namespace TestDrivenDevelopmentTests;

public class Tests
{
    [Test]
    public void Given2_FizzBuzz_Returns1and2()
    {
        int maxValue = 2;
        Assert.That(Program.FizzBuzz(maxValue), Is.EqualTo("1 2"));
    }
   
    [Test]
    public void GivenSomeMaximumValue_FizzBuzz_ReturnAllNumbers()
    {
        int maxValue = 10;
        string expectedValue = "1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz";
        Assert.That(Program.FizzBuzz(maxValue), Is.EqualTo(expectedValue));

    }
    [Test]
    public void Given3_FizzBuzz_Returns_1_2_Fizz()
    {
        int maxValue = 3;
        string expectedValue = "1 2 Fizz";
        Assert.That(Program.FizzBuzz(maxValue), Is.EqualTo(expectedValue));

    }
    [Test]
    public void GivenMaxvalue_FizzBuzz_ReturnsFizzBuzz()
    {
        int maxValue = 16;
        string expectedValue = "1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz 16";
        Assert.That(Program.FizzBuzz(maxValue), Is.EqualTo(expectedValue));

    }




}