class Program
{
    static void Main(string[] args)
    {
        // ForLoop();
        //WhileLoop();
        // DoWhileLoop();
        // ForEachLoop();
        if (IsPrimeNumber(6))
        {
            Console.WriteLine("This is a prime number");
        }
        else
        {
            Console.WriteLine("This is not a prime number");
        }
    }

    private static bool IsPrimeNumber(int number)
    {
        bool result = true;
        for (int i = 2; i < number-1; i++)
        {
            if (number % i == 0)
            {
                result = false;
                i = number;
            }
                
        }
        return result;  


    }
    
    
    
    
    
    // For Each Loop
    private static void ForEachLoop()
    {
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

