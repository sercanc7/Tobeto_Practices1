
// string city = "Ankara";
// Console.WriteLine(city[0]);
//foreach (var item in city)
//{
//    Console.WriteLine(item);
//}

//string city2 = "Istanbul";

// Uzun Metot
// string result = city + city2;
// Console.Writeline(result);
//Console.WriteLine("{0} {1}", city, city2);
//Console.ReadLine();

string sentence = "My name is Engin Demiroğ";
var result = sentence.Length;
var result2 = sentence.Clone();
sentence = "My name is Derin Demiroğ";

bool result3 = sentence.EndsWith("ğ");
bool result4 = sentence.StartsWith("My Name");

var result5 = sentence.IndexOf("name");
var result6 = sentence.IndexOf(" "); // İlk boşluğu yazdırır
var result7 = sentence.LastIndexOf(" "); // Aramaya sondan başlar
var result8 = sentence.Insert(0, "Hello, ");// Cümlenin 0.karakterinden itibaren ekleme yapar.
var result9 = sentence.Substring(3,4); // 3.karakterden itibaren 4 tane al.
var result10 = sentence.ToLower(); // Bütün karakterleri küçüğe çevirir.
var result11 = sentence.ToUpper(); // Bütün karakterleri büyüğe çevirir.
var result12 = sentence.Replace(" ", "-"); // 
var result13 = sentence.Remove(2,5); // Bir metinden belli indexten sonrasını atmak için.

Console.WriteLine(result13);
Console.ReadLine();