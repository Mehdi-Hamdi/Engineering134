using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;
using Op_CtrlFlow;
using System;
using System.Collections.Generic;

namespace Op_CtrlFlow_Tests
{
    public class Exercises_Tests
    {
       
        
        [TestCase(1, 1)]
        [TestCase(3, 2)]
        public void WhenEqual_ReturnFalse(int num1, int num2)
        {
            bool output = Exercises.MyMethod(num1, num2);
            Assert.That(output, Is.EqualTo(false));
        }

        [TestCase(4, 2)]
        public void WhenEqual_ReturnTrue(int num1, int num2)
        {
            bool output = Exercises.MyMethod(num1, num2);
            Assert.That(output, Is.EqualTo(true));
        }


        [Test]
        public void Average_ReturnsCorrectAverage()
        {
            var myList = new List<int>() { 3, 8, 1, 7, 3 };
            Assert.That(Exercises.Average(myList), Is.EqualTo(4.4));
        }

        [Test]
        public void WhenListIsEmpty_Average_ReturnsZero()
        {
            var myList = new List<int>() { };
            Assert.That(Exercises.Average(myList), Is.EqualTo(0));
        }
        


        [TestCase(100, "OAP")]
        [TestCase(60, "OAP")]
        [TestCase(59, "Standard")]
        [TestCase(18, "Standard")]
        [TestCase(17, "Student")]
        [TestCase(13, "Student")]
        [TestCase(12, "Child")]
        [TestCase(5, "Child")]
        [TestCase(4, "Free")]
        [TestCase(0, "Free")]
        public void TicketTypeTest(int age, string expected)
        {
            var result = Exercises.TicketType(age);
            Assert.That(result, Is.EqualTo(expected));
        }
        [TestCase(59)]
        [TestCase(48)]
        [TestCase(40)]
        public void WhenGradeLessThan60GreaterThan39_ReturnsPass(int mark)
        {
            string output = Exercises.Grade(mark);
            Assert.That(output, Is.EqualTo("Pass"));
        }

        [TestCase(74)]
        [TestCase(67)]
        [TestCase(60)]
        public void WhenGradeLessThan75GreaterThan59_ReturnsPass(int mark)
        {
            string output = Exercises.Grade(mark);
            Assert.That(output, Is.EqualTo("Pass with Merit"));
        }

        [TestCase(39)]
        [TestCase(20)]
        [TestCase(0)]
        public void WhenGradeIsLessThan40_ReturnsFail(int mark)
        {
            string output = Exercises.Grade(mark);
            Assert.That(output, Is.EqualTo("Fail"));
        }

        [TestCase(75)]
        [TestCase(90)]
        [TestCase(100)]
        public void WhenGradeGreaterThan74_ReturnsPass(int mark)
        {
            string output = Exercises.Grade(mark);
            Assert.That(output, Is.EqualTo("Pass with Distinction"));
        }
        
        [TestCase(-1)]
        [TestCase(101)]
        public void whenMarkIsOutsideOfRange_Grade_ThrowsArgumentOutOfRangeException(int mark)
        {
            Assert.That(() => Exercises.Grade(mark), Throws.TypeOf<ArgumentOutOfRangeException>().With.Message.Contain
                ("Mark cannot be outside the range 0-100"));
        }
    


    [TestCase(0)]
        public void WhenLevel0_Returns200(int covidLevel)
        {
            int output = Exercises.GetScottishMaxWeddingNumbers(covidLevel);
            Assert.That(output, Is.EqualTo(200));
        }

        [TestCase(1)]
        public void WhenLevel1_Returns100(int covidLevel)
        {
            int output = Exercises.GetScottishMaxWeddingNumbers(covidLevel);
            Assert.That(output, Is.EqualTo(100));
        }

        [TestCase(3)]
        public void WhenLevel3_Returns50(int covidLevel)
        {
            int output = Exercises.GetScottishMaxWeddingNumbers(covidLevel);
            Assert.That(output, Is.EqualTo(50));
        }


        [TestCase(4)]
        public void WhenLevel4_Returns20(int covidLevel)
        {
            int output = Exercises.GetScottishMaxWeddingNumbers(covidLevel);
            Assert.That(output, Is.EqualTo(20));
        }

        [TestCase(2)]
        public void WhenLevel2_Returns50(int covidLevel)
        {
            int output = Exercises.GetScottishMaxWeddingNumbers(covidLevel);
            Assert.That(output, Is.EqualTo(50));
        }
    }
}
