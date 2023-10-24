class Program
{
    static void Main(string[] args)
    {
        Add();
        Add();
        Add();
        var result = Add2(2, 5);
        Console.WriteLine(result);
        Console.ReadLine();
    }

    static void Add()
    {
        Console.WriteLine("Added!!!");
    }

    // Toplama Fonksiyonu Oluşturuldu.
    static int Add2(int number1,int number2)
    {
       var result = number1 + number2;
        return result;

    }
}