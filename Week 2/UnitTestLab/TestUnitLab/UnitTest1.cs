using UnitTestLab;

namespace TestUnitLab
{
    public class Tests
    {
        public class Classification_Tests
        {
            [TestCase(0)]
            [TestCase(8)]
            [TestCase(11)]
            public void GivenAgeUnder12_GetAvaiableClassifications_ReturnsUandPG(int ageOfViewer)
            {
                int age = ageOfViewer;

                string output = Program.AvailableClassifications(age);

                Assert.That(output, Is.EqualTo("U & PG films are available."));
            }

            [TestCase(12)]
            [TestCase(13)]
            [TestCase(14)]
            public void GivenAgeUnder15_GetAvaiableClassifications_ReturnsUandPGand12(int ageOfViewer)
            {
                int age = ageOfViewer;

                string output = Program.AvailableClassifications(age);

                Assert.That(output, Is.EqualTo("U, PG & 12 films are available."));
            }

            [TestCase(15)]
            [TestCase(16)]
            [TestCase(17)]
            public void GivenAgeUnder18_GetAvaiableClassifications_ReturnsUandPGand12and15(int ageOfViewer)
            {
                int age = ageOfViewer;

                string output = Program.AvailableClassifications(age);

                Assert.That(output, Is.EqualTo("U, PG, 12 & 15 films are available."));
            }

            [TestCase(18)]
            public void GivenAge18_GetAvaiableClassifications_ReturnsUandPGand12and15and18(int ageOfViewer)
            {
                int age = ageOfViewer;

                string output = Program.AvailableClassifications(age);

                Assert.That(output, Is.EqualTo("U, PG, 12, 15 & 18 films are available."));
            }

            [TestCase(19)]
            [TestCase(25)]
            [TestCase(32)]
            public void GivenAgeOver18_GetAvaiableClassifications_ReturnsAllFilmsAvailable(int ageOfViewer)
            {
                int age = ageOfViewer;

                string output = Program.AvailableClassifications(age);

                Assert.That(output, Is.EqualTo("All films are available."));
            }
        }
    }
}