namespace ChallengeApp.Tests;

 public class Tests
{

    [Test]

    public void WhenEmployeeCollectsScore_ShouldCorrectSumAsResult()

    {

        //arrange

        var employee = new Employee("Jan", "Kowalski", 30);

        employee.AddScore(2);

        employee.AddScore(6);

        employee.AddScore(4);

        employee.AddScore(-8);

        employee.AddScore(-1);


        //act

        var result = employee.Result;


        //assert

        Assert.AreEqual(3, result);

    }
}