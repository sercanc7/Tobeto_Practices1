
// Uzun Metot
string[] students = new String[3];
students[0] = "Engin";
students[1] = "Derin";
students[2] = "Salih";


// Kısa Metot
string[] students2 = { "Engin", "Derin", "Salih" };

foreach (var student in students2)
{
    //Console.WriteLine(student);
}

string[,] regions = new String[5, 3]
{
    {"İstanbul","İzmit","Balıkesir" },
    {"Ankara","Konya","Kırıkkale" } ,
    {"Antalya","Adana","Mersin" } ,
    {"Rize","Trabzon","Samsun"} ,
    {"İzmir","Muğla","Manisa"}

};

for (int i = 0; i <= regions.GetUpperBound(0); i++)
{
    for (int j = 0; j < regions.GetUpperBound(1); j++)
    {
        Console.WriteLine(regions[i, j]);
    }

    Console.WriteLine("******");
}


Console.ReadLine();