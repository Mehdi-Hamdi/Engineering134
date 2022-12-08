using CodeToTest;

namespace UnitTests
{
    public class Tests
    {


        [Test]
        public void GivenTimeOf5_GetGreeting_ReturnsGoodMorning()
        {
            //given a time of 5
            //Arrange our precondition
            int time = 5;

            //when i call GetGreeting
            //Act
            string output = Program.GetGreeting(time);

            //Assert that it returned "Good Morning!"
            Assert.That(output, Is.EqualTo("Good Morning!"));
        }

        [Test]
        public void GivenTimeOf13_GetGreeting_ReturnsGoodAfternoon()
        {
            //given a time of 13
            //Arrange our precondition
            int time = 13;

            //when i call GetGreeting
            //Act
            string output = Program.GetGreeting(time);

            //Assert that it returned "Good Afternoon!"
            Assert.That(output, Is.EqualTo("Good Afternoon!"));
        }

        [Test]
        public void GivenTimeOf19_GetGreeting_ReturnsGoodEvening()
        {
            //given a time of 19
            //Arrange our precondition
            int time = 19;

            //when i call GetGreeting
            //Act
            string output = Program.GetGreeting(time);

            //Assert that it returned "Good Evening!"
            Assert.That(output, Is.EqualTo("Good Evening!"));
        }

        [TestCase(5)]
        [TestCase(8)]
        [TestCase(11)]
        public void GivenMorningBoundaryValues_GetGreeting_ReturnsGoodMorning(int timeOfDay)
        {
            //given a time of timeOfDay
            //Arrange our precondition
            int time = timeOfDay;

            //when i call GetGreeting
            //Act
            string output = Program.GetGreeting(time);

            //Assert that it returned "Good Morning!"
            Assert.That(output, Is.EqualTo("Good Morning!"));
        }

        [TestCase(12)]
        [TestCase(15)]
        [TestCase(18)]
        public void GivenAfternoonBoundaryValues_GetGreeting_ReturnsGoodAfternoon(int timeOfDay)
        {
            //given a time of timeOfDay
            //Arrange our precondition
            int time = timeOfDay;

            //when i call GetGreeting
            //Act
            string output = Program.GetGreeting(time);

            //Assert that it returned "Good Afternoon!"
            Assert.That(output, Is.EqualTo("Good Afternoon!"));
        }

        [TestCase(19)]
        [TestCase(21)]
        [TestCase(23)]
        public void GivenEveningBoundaryValues_GetGreeting_ReturnsGoodEvening(int timeOfDay)
        {
            //given a time of timeOfDay
            //Arrange our precondition
            int time = timeOfDay;

            //when i call GetGreeting
            //Act
            string output = Program.GetGreeting(time);

            //Assert that it returned "Good Evening!"
            Assert.That(output, Is.EqualTo("Good Evening!"));
        }

        [TestCase(0)]
        [TestCase(2)]
        [TestCase(4)]
        public void GivenEarlyMorningBoundaryValues_GetGreeting_ReturnsGoodEvening(int timeOfDay)
        {
            //given a time of timeOfDay
            //Arrange our precondition
            int time = timeOfDay;

            //when i call GetGreeting
            //Act
            string output = Program.GetGreeting(time);

            //Assert that it returned "Good Evening!"
            Assert.That(output, Is.EqualTo("Good Evening!"));
        }
    }
    
}
