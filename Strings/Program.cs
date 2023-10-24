string city = "Ankara";
// Console.WriteLine(city[0]);
foreach (var item in city)
{
    Console.WriteLine(item);
}

string city2 = "Istanbul";

// Uzun Metot
// string result = city + city2;
// Console.Writeline(result);
Console.WriteLine("{0} {1}", city, city2);
Console.ReadLine();