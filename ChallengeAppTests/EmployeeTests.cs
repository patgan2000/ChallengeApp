using System.Security.Cryptography.X509Certificates;

namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void WhenEmployeeCollectsGrades_ShouldGetAverage()
        {
            var emp = new Employee("Anna", "Nowak");
            emp.AddGrade(5);
            emp.AddGrade(4);
            emp.AddGrade(9);

            var statistics = emp.GetStatistics();

            Assert.AreEqual(6, statistics.Avr);
        }
        [Test]
        public void WhenEmployeeCollectsGrades_ShouldGetMin()
        {
            var emp = new Employee("Anna", "Nowak");
            emp.AddGrade(5);
            emp.AddGrade(4);
            emp.AddGrade(9);

            var statistics = emp.GetStatistics();

            Assert.AreEqual(4, statistics.Min);
        }
        [Test]
        public void WhenEmployeeCollectsGrades_ShouldGetMax()
        {
            var emp = new Employee("Anna", "Nowak");
            emp.AddGrade(5);
            emp.AddGrade(5);
            emp.AddGrade(9);

            var statistics = emp.GetStatistics();

            Assert.AreEqual(9, statistics.Max);
        }

        [Test]
        public void WhenEnterLetterGrade_ShouldGetValueGrade()
        {
            Employee emp = new Employee("Anna", "Nowak");
            emp.AddGrade('a');
            emp.AddGrade('F');
            emp.AddGrade('b');

            var statistics = emp.GetStatistics();

            Assert.AreEqual(4, statistics.Avr);
        }

        [Test]
        public void WhenEnterValueGrade_ShouldGetLetterGrade()
        {
            Employee emp = new Employee("Anna", "Nowak");
            emp.AddGrade(8);
            emp.AddGrade(5);
            emp.AddGrade(8);

            var statistics = emp.GetStatistics();

            Assert.AreEqual('A', statistics.AvrLetter);
        }

    }
}