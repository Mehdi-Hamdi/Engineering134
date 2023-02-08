﻿using NUnit.Framework;
using ClassesApp;

namespace ClassesTests
{
   
    public class BaseClassTests
    {
        [TestCase("Cathy", "French", "Cathy French") ]
        [TestCase("", "", " ")]
        public void GetFullNameTest(string fName, string lName, string expected)
        {
            // create a new BaseClass object, which represents a person
            var subject = new BaseClass(fName, lName);
            var result = subject.GetFullName();
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void AgeTest()
        {
            var subject = new BaseClass("A", "B");
            subject.Age = 35;
            Assert.AreEqual(35, subject.Age);
        }

        [Test]
        public void ToStringTest()
        {
            var subject = new BaseClass("Cathy", "French", 4, "High Street", "Stafford");
            subject.Age = 22;
            var result = subject.ToString();
            Assert.AreEqual("ClassesApp.BaseClass Name: Cathy French Age: 22. Address: 4 High Street, Stafford", result);
        }
    }
}
