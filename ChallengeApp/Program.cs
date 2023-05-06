using ChallengeApp;

Console.WriteLine("Witaj w programie XYZ służacym do oceny pracownika");
Console.WriteLine("==================================================");
Console.WriteLine();
var em = new EmployeeInFile("Anna","Nowak");
em.AddGrade(0.5f);
em.AddGrade(40);
em.AddGrade(+3);
em.AddGrade(21);

//while (true)
//{
//    Console.WriteLine("Podaj kolejną ocenę pracownika");
//    var input = Console.ReadLine();
//    if (input == "q")
//    {
//        break;
//    }

//    try
//    {
//        em.AddGrade(input);

//    }
//    catch (Exception e)
//    {
//        Console.WriteLine($"Exception catched: {e.Message}");

//    }
//}

//var statistics = em.GetStatistics();
//Console.WriteLine($"AVR: {statistics.Avr}");
//Console.WriteLine($"Min: {statistics.Min}");
//Console.WriteLine($"Max: {statistics.Max}");