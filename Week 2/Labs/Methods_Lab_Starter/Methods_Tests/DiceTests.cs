using NUnit.Framework;
using System;
using Methods_Lib;

namespace Methods_Tests
{
    public class DiceTests
    {
        [Test]
        public void GivenRnd_RollDice_RreturnsValueExpected()
        {
            Random rnd = new(1);
            int val = Methods.RollDice(rnd);

            Assert.That(val, Is.EqualTo(3));
        }
    }
}
