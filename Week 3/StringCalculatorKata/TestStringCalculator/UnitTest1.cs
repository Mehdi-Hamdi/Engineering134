using StringCalculatorKata;
namespace TestStringCalculator;

public class Tests
{
    
    [Test]
    public void Given1_2_Add_Return3()
    {
        string input = "1,2";

        int result = Program.Add(input);
        
        Assert.That(3, Is.EqualTo(result));
        
    }

    [Test]
    public void GivenUnknown_Add_ReturnsSum()
    {
        string input = "1,2,4";

        int result = Program.Add(input);

        Assert.That(7, Is.EqualTo(result));

    }

    [Test]
    public void GivenUnknownSeperatedLines_Add_ReturnsSum()
    {
        string input = "1,2\n4";

        int result = Program.Add(input);

        Assert.That(7, Is.EqualTo(result));

    }
}