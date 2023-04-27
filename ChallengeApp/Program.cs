using ChallengeApp;

Console.WriteLine("Witaj w programie XYZ służacym do oceny pracownika");
Console.WriteLine("==================================================");
Console.WriteLine();
var em = new Employee();

while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    em.AddGrade(input);
}

var statistics = em.GetStatistics();
Console.WriteLine($"AVR: {statistics.Avr}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");