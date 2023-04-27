Employee em1 = new Employee("Marcin", "Kowal", 20);
Employee em2 = new Employee("Mateusz", "Kowalczyk", 30);
Employee em3 = new Employee("Mariusz", "Kowalski", 40);

em1.AddScore(2);
em1.AddScore(5);
em1.AddScore(3);
em1.AddScore(8);
em1.AddScore(1);

em2.AddScore(6);
em2.AddScore(2);
em2.AddScore(3);
em2.AddScore(4);
em2.AddScore(9);

em3.AddScore(1);
em3.AddScore(1);
em3.AddScore(8);
em3.AddScore(7);
em3.AddScore(10);

var result1 = em1.Result;
var result2 = em2.Result;
var result3 = em3.Result;

List<Employee> employees = new List<Employee>
{
    em1, em2, em3
};

int maxResult = -1;
Employee? bestEmployee = null;

Console.WriteLine("Najlepszym pracownikiem jest " + bestEmployee.Name + " " + bestEmployee.Surname);
Console.WriteLine("A jego wynik to:" + " " + maxResult);