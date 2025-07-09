
using System;
namespace Program 
{
class Program
{
    static void Main(string[]args)
    {
        Console.WriteLine("to detect whether number is even or odd");
        Console.WriteLine(" ______________________________________________");
        Console.Write("| please provide the number you want to verify |: ");
        
        int number = Convert.ToInt32 (Console.ReadLine ( ));
       
        Console.WriteLine(" ----------------------------------------------");
        Console.WriteLine("  ");

        if ((number/2)*2 == number  )
        {
            Console.WriteLine($"{number} is even number");
        }

        else
        {
            Console.WriteLine ($"{number} is odd number");
        }
        
        
    }
}

}
