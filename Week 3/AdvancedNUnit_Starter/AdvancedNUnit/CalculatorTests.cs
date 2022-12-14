using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace AdvancedNUnit
{
    [TestFixture]
    public class CalculatorTests
    {
        List<int> myList;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {

        }
        [SetUp]
        public void Setup() 
        {
            myList = new List<int> { 1, 2, 3 };
        
        }

        [Test]
        public void Add_Always_ReturnsExpectedResult()
        {
            // Arrange
            var expectedResult = 6;
            var subject = new Calculator { Num1 = 2, Num2 = 4 };
            // Act
            var result = subject.Add();
            // Assert
            Assert.That(result, Is.EqualTo(expectedResult), "optional failure message");
        }

        [TearDown]
        public void TearDown()
        {
            //i run after every test
        }

        [Test]
        public void PlayingWithConstraints()
        {
            //arrange
            var subject = new Calculator { Num1 = 6 };

            //Act and assert
            Assert.That(subject.DivisibleBy3());
            subject.Num1 = 7;
            Assert.That(subject.DivisibleBy3(), Is.False);
            Assert.That(subject.ToString(), Does.Contain("Calculator"));
      
        }

        [Test]
        public void StringConstraints()
        {
            var subject = new Calculator { Num1 = 2, Num2 = 4 };
            
            var expectedStr = "AdvancedNUnit.Calculator";
            Assert.That(subject.ToString(), Is.EqualTo(expectedStr));
            Assert.That(subject.ToString(), Does.Not.Contain("Potato").IgnoreCase);
            Assert.That(subject.ToString(), Is.Not.Empty);
        }

        [Test]
        public void RangeConstraint()
        {
            List<int> myDiceRolls = new() { 6, 6 };
            var myDiceRolls2 = new List<int> { 1, 6 };

            Assert.That(myDiceRolls[0], Is.InRange(1, 6));
            Assert.That(myDiceRolls[0], Is.All.InRange(1, 6));
            Assert.That(myDiceRolls, Has.Member(1));
        }

        [Test]
        public void StartWithConstraints()
        {
            string phrase = "work";
            Assert.That(phrase, Does.StartWith("wor"));

        }

        [Test]
        public void Array2inTest()
        {
            int[] arraytest = {23, 31, 5, 6, 43};
            Assert.That(arraytest, Has.Exactly(2).InRange(1, 10));
        }

        
    }
    
}