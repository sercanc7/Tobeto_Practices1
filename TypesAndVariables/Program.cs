//Value Types
// Console.WriteLine("Hello, World!");

//Integer 
int number1 = 10;

//short
short number3 = -32768;

//long
long number2 = 21474836471231231;

//byte
byte number4 = 255;

//bool
bool condition = true;

//Char
char character = 'A';

//Double
double number5 = 10.4;

//Decimal
decimal number6 = 10.4m;
Console.WriteLine("Number1 is :{0}", number1);
Console.WriteLine("Number2 is :{0}", number2);
Console.WriteLine("Number3 is :{0}", number3);
Console.WriteLine("Number4 is :{0}", number4);
Console.WriteLine("Number5 is :{0}", number5);
Console.WriteLine("Character is :{0}",(int)character);
Console.WriteLine((int)Days.Friday);
Console.ReadLine();

enum Days
{
    Monday,Tuesday, Wednesday,Thursday,Friday,Saturday,Sunday
}

