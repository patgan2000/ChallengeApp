string name_1 = "Ewa";
var age_1 = 12;
string sex_1 = "Kobieta";

if (age_1 < 30 && sex_1 == "Kobieta")
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}

else if (name_1 == "Ewa" && age_1 == 33)
{
    Console.WriteLine("Ewa, lat 33");
}

else if (age_1 < 18 && sex_1 != "Kobieta")
{
    Console.WriteLine("Niepełnoletni mężczyznaa");
}