var number = 11;

//if (number==10)
//{
//    Console.WriteLine("Number is 10");
//}
//else if (number ==20)
//{
//    Console.WriteLine("Number is not 20");
//}

//else
//{
//    Console.WriteLine("Number is not 10 or 20");
//}
switch (number)
{
    case 10:
        Console.WriteLine("Number is 10");
        break;

    case 20:
        Console.WriteLine("Number is 20");
        break;

    default:
        Console.WriteLine("Number is not 10 or 20");
        break;
}


Console.ReadLine();

