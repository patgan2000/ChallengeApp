namespace ChallengeApp.Tests
{
    public class EmployeTests
    {

        [Test]
        public void WhenEmployeeCollectsGrades_ShouldGetAverage()
        {
            var emp = new Employee("Jan", "Kowalski");
            emp.AddGrade(5);
            emp.AddGrade(-5);
            emp.AddGrade(-9);

            var statistics = emp.GetStatistics();

            Assert.AreEqual(-3, statistics.Avr);
        }

        [Test]
        public void WhenEmployeeCollectsGrades_ShouldGetMin()
        {
            var emp = new Employee("Jan", "Kowalski");
            emp.AddGrade(5);
            emp.AddGrade(-5);
            emp.AddGrade(-9);

            var statistics = emp.GetStatistics();

            Assert.AreEqual(-9, statistics.Min);
        }

        [Test]
        public void WhenEmployeeCollectsGrades_ShouldGetMax()
        {
            var emp = new Employee("Jan", "Kowalski");
            emp.AddGrade(5);
            emp.AddGrade(-5);
            emp.AddGrade(-9);

            var statistics = emp.GetStatistics();

            Assert.AreEqual(5, statistics.Max);


        }
    }
}