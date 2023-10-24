class Program
{
    static void Main(string[] args)
    {
        // ForLoop();
        int number = 100;
        while (number>=0)
        {
            Console.WriteLine(number);
            number--;
        }
        Console.WriteLine("Now number is {0}", number);
    }
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

