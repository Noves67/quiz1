using System;
 class Programs{
    public static void Mian(string[]arges)
    {
        Console.WriteLine(" Enter number brtween 1 and 7:");
        int num= int.Parse(Console.ReadLine());
       
        switch (num )
        {
          case 1:
          Console.WriteLine("Monday");
             break;
            case 2:
            Console.WriteLine("Tuesday");
            break;
            default:
            Console.WriteLine("no");
               break;
        }
    }
}