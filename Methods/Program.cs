class Program
{
    static void Main(string[] args)
    {
        Add();
        Add();
        Add();
        var result = Add2(20);
        Console.WriteLine(result);
        Console.ReadLine();
        
    }

    static void Add()
    {
        Console.WriteLine("Added!!!");
    }

    // Toplama Fonksiyonu Oluşturuldu.
    // Default değerler metodun son değerinde olur.
    static int Add2(int number1,int number2=30)
    {
       var result = number1 + number2;
        return result;

    }
}