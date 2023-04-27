using ChallengeApp;

Console.WriteLine("Witaj w programie XYZ służacym do oceny pracownika");
Console.WriteLine("==================================================");
Console.WriteLine();
var em = new Employee("Anna","Nowak");

while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }

    try
    {
        em.AddGrade(input);

    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception catched: {e.Message}");

    }
}

var statistics = em.GetStatistics();
Console.WriteLine($"AVR: {statistics.Avr}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");