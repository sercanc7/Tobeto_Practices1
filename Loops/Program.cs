class Program
{
    static void Main(string[] args)
    {
        // ForLoop();
        //WhileLoop();
        // DoWhileLoop();
        string[] students2 = { "Engin", "Derin", "Salih" };
        foreach (var student in students2)
        {
            Console.WriteLine(student);
        }
    }
    


    // Do While Döngüsü
    private static void DoWhileLoop()
    {
       int number = 10;
       do
       {

        Console.WriteLine(number);
        number--;

        } while(number >= 11);
    }

    
    // While Döngüsü
    private static void WhileLoop() 
    {
        int number = 100;
        while (number >= 0)
     {
        Console.WriteLine(number);
        number--;
     }
     Console.WriteLine("Now number is {0}", number);
     }
        
    // For Döngüsü
    private static void ForLoop()
    {
        for (int i = 0; i <= 100; i = i + 2)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("Finished!");
        Console.ReadLine();
    }
}

