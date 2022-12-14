using NUnit.Framework;

namespace AdvancedNUnit
{
    [TestFixture]
    //[Ignore("Not using these tests yet")]
    public class CounterTests
    {
        [SetUp]
        public void Setup()
        {
            _sut = new Counter(6);
        }
        private Counter _sut = new Counter(6);

        [Test]
        [Category("Counter Tests")]
        public void GivenCounter_Increment_IncreaseCountByOne()
        {
            _sut.Increment();
            Assert.That(_sut.Count, Is.EqualTo(7));
        }
        [Test]
        [Category("Counter Tests")]
        public void Decrement_DecreasesCountByOne()
        {
            _sut.Decrement();
            Assert.That(_sut.Count, Is.EqualTo(5));
        }
    }
}
