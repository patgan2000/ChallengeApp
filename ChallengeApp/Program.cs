using ChallengeApp;

var emp = new Employee("Jan", "Nowak");
emp.AddGrade("Cztery");
emp.AddGrade("4000");
emp.AddGrade(-1);
emp.AddGrade(9.4);
emp.AddGrade(2);
emp.AddGrade(4);

var statistics = emp.GetStatistics();
var statistics1 = emp.GetStatisticsForEach();
var statistics2 = emp.GetStatisticsFor();
var statistics3 = emp.GetStatisticsDoWhile();
var statistics4 = emp.GetStatisticsWhile();


Console.WriteLine($"Average: {statistics.Avr:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");