using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp1
{
  
   


    class Program
    {
       
        static void Main(string[] args)
        {
            int num1;
            int num2;

            int result;

            string answer;
            
            Console.WriteLine("Welcome to the calculator program!");
            Console.WriteLine("Enter your first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What type of operation would you like to do?");
            Console.WriteLine("a = addition");
            Console.WriteLine("s = substraction");
            Console.WriteLine("c = multiplication");
            Console.WriteLine("d = division");

            answer = Console.ReadLine();

            if (answer == "a")
            {
                result = num1 + num2;
            }
            else if (answer == "s")
            {
                result = num1 - num2;
            }
            else if (answer == "c")
            {
                result = num1 * num2;
            }
            else
            {
                result = num1 / num2;
            }
            

            Console.WriteLine("The result is " + result);

            Console.ReadKey();


        }


    }
}
