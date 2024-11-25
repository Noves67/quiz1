 using System;
 public class Programm{
    public static void Mian(string[]arges){
        Console.WriteLine("Enter number?");
        int num =int.Parse(Console.ReadLine());
        
        if (num>0)
        {
          Console.WriteLine("the number is Positive.");

        }
       else if ( num<0)
       {
        Console.WriteLine("the number is Negative.");
       } 
        else  
        {
            Console.WriteLine("the number eqwle Zero.");
        }


    }
  }
